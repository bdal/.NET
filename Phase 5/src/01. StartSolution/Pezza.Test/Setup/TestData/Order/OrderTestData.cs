﻿namespace Pezza.Test.Setup.TestData.Order;

using System;
using System.Collections.Generic;
using Bogus;
using Pezza.Common.DTO;
using Pezza.Test.Setup.TestData.Customer;
using Pezza.Test.Setup.TestData.Product;
using Pezza.Test.Setup.TestData.Restaurant;

public static class OrderTestData
{
    public static Faker faker = new Faker();

    public static List<OrderDTO> OrdersDTO()
    {
        var orders = new List<OrderDTO>
        {
            OrderDTO,
            OrderDTO,
            OrderDTO,
            OrderDTO,
            OrderDTO
        };

        return orders;
    }

    public static OrderDTO OrderDTO = new OrderDTO()
    {
        Amount = faker.Finance.Amount(),
        Customer = CustomerTestData.CustomerDTO,
        CustomerId = 1,
        Restaurant = RestaurantTestData.RestaurantDTO,
        RestaurantId = 1,
        DateCreated = DateTime.Now,
        Completed = false,
        OrderItems = new List<OrderItemDTO>
        {
            new OrderItemDTO()
            {
                OrderId = 1,
                Product = ProductTestData.ProductDTO
            }
        }
    };

    public static OrderItemDTO OrderItemDTO = new OrderItemDTO()
    {
        OrderId = 1,
        Product = ProductTestData.ProductDTO
    };
}
