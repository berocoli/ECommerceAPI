using Application.DTOs;
using Application.Exceptions;
using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Queries.Orders.GetOrdersById
{
    public class GetOrdersByIdQueryHandler : IRequestHandler<GetOrdersByIdQueryRequest, List<GetOrdersByIdQueryResponse>>
    {
        private readonly IOrderService _orderService;

        public GetOrdersByIdQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<List<GetOrdersByIdQueryResponse>> Handle(GetOrdersByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var orders = await _orderService.GetOrderByIdAsync(request.OrderId);

            if (orders == null || !orders.Any())
            {
                throw new GetRequestFailedException("No orders found for the given ID.");
            }

            // Construct response manually
            var response = orders.Select(order => new GetOrdersByIdQueryResponse
            {
                Id = order.Id,
                UserId = order.UserId,
                Address = order.Address,
                Description = order.Description,
                Status = order.Status,
                Cart = new GetCartDto
                {
                    Id = order.Cart.Id,
                    UserId = order.Cart.UserId,
                    IsModifyable = order.Cart.IsModifyable,
                    CartProducts = order.Cart.CartProducts.Select(cartItem => new CartProductDto
                    {
                        ProductId = cartItem.ProductId,
                        Product = new ProductDto
                        {
                            Id = cartItem.Product.Id.ToString(),
                            Name = cartItem.Product.Name,
                            Description = cartItem.Product.Description,
                            Price = cartItem.Product.Price,
                            ImageUrl = cartItem.Product.ImageUrl,
                            CategoryId = cartItem.Product.CategoryId.ToString(),
                            CategoryName = cartItem.Product.CategoryName
                        },
                        Quantity = cartItem.Quantity
                    }).ToList()
                }
            }).ToList();

            return response;
        }
    }
}
