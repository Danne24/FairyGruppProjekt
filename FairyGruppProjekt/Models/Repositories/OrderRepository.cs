﻿using FairyGruppProjekt.Data;
using FairyGruppProjekt.Models.Interfaces;

using Microsoft.CodeAnalysis;


using Microsoft.EntityFrameworkCore;
using System;

namespace FairyGruppProjekt.Models.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;


        public OrderRepository(ApplicationDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Today;
            order.ExactDateOrderplaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();


            foreach (var shoppigCartItem in shoppingCartItems)
            {
                var orderDetails = new OrderDetail
                {
                    Amount = shoppigCartItem.Amount,
                    Price = shoppigCartItem.Product.Price,
                    ProductId = shoppigCartItem.Product.ProductId,
                    OrderId = order.OrderId,
                    
                };

                shoppigCartItem.Product.AmountOfCopiesInStorage = shoppigCartItem.Product.AmountOfCopiesInStorage - orderDetails.Amount;
                shoppigCartItem.Product.AmountOfCopiesSold =+ orderDetails.Amount;

                _appDbContext.OrderDetails.Add(orderDetails);
            }
            _appDbContext.SaveChanges();
        }


        public IEnumerable<Order> GetAllOrdersForDashboard
        {
            get
            {
                return _appDbContext.Orders.Include(o => o.OrderDetails);
            }
        }

        public IEnumerable<Order> GetStatistic
        {
            get
            {
                return _appDbContext.Orders.Include(o => o.OrderDetails).Where(o => o.OrderPlaced == DateTime.Today);
            }
        }

        //public int GetStatistic()
        //{
        //    var orders = _appDbContext.Orders.Include(o => o.OrderDetails).Where(o => o.OrderPlaced == DateTime.Today).Count();

        //    return orders;
        //}


        public IEnumerable<Order> GetAllOrders()
        {
            return _appDbContext.Orders.Include(o => o.OrderDetails).ToList();
        }

        public Order GetOrderById(int id)
        {
            var orderDetail = _appDbContext.Orders.Include(o => o.OrderDetails).ThenInclude(p=>p.Product).FirstOrDefault(o => o.OrderId == id);
            
            return orderDetail;
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            return _appDbContext.OrderDetails.ToList();
        }

        public IEnumerable<Product> MostSoldProducts()
        {
            var query = from p in _appDbContext.Products
                        let totalQuantity = (from op in _appDbContext.OrderDetails
                                             join o in _appDbContext.Orders on op.OrderId equals o.OrderId
                                             where op.ProductId == p.ProductId && o.OrderPlaced > DateTime.Today.AddDays(-31)
                                             select op.Amount).Sum()

                        where totalQuantity > 0
                        orderby totalQuantity descending
                        select p;
            
            return query;
        }
    }
}
