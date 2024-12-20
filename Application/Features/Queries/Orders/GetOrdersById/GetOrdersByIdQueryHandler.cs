using Application.DTOs;
using Application.Exceptions;
using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Queries.Orders.GetOrdersById
{
    public class GetOrdersByIdQueryHandler : IRequestHandler<GetOrdersByIdQueryRequest, GetOrdersByIdQueryResponse>
    {
        private readonly IOrderService _orderService;

        public GetOrdersByIdQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetOrdersByIdQueryResponse> Handle(GetOrdersByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderService.GetOrderByIdAsync(request.OrderId);

            if (order == null)
            {
                throw new GetRequestFailedException("No order found for the given ID.");
            }

            // Construct the response manually
            var response = new GetOrdersByIdQueryResponse
            {
                Id = order.Id,
                UserId = order.UserId,
                Address = order.Address,
                Description = order.Description,
                Status = order.Status,
                CartItems = order.Cart == null
                    ? null
                    : new GetCartDto
                    {
                        Id = order.Cart.Id,
                        UserId = order.Cart.UserId,
                        IsModifyable = order.Cart.IsModifyable,
                        CartProducts = order.Cart.CartProducts == null
                            ? new List<CartProductDto>() // Default to an empty list if null
                            : order.Cart.CartProducts.Select(cartItem => new CartProductDto
                            {
                                ProductId = cartItem.ProductId,
                                Product = cartItem.Product == null
                                    ? null
                                    : new ProductDto
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
            };

            return response;
        }
    }
}