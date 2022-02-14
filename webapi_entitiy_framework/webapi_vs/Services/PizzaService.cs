﻿using webapi_vs.Models;
using webapi_vs.Data;
using Microsoft.EntityFrameworkCore;

namespace webapi_vs.Services
{
    public class PizzaService
    {
        private readonly PizzaContext _context;
        // When the PizzaSerivce instance is created, a PizzaContext will be injected as dependency
        public PizzaService(PizzaContext pizzaContext)
        {
            _context = pizzaContext;
        }

        // Attention! Topings and sauces are NULLs here!
        public IEnumerable<Pizza> GetAll()
        {
            return _context.Pizzas
                .AsNoTracking()
                .ToList();
        }

        public Pizza? GetById(int id)
        {
            return _context.Pizzas
                           .Include(p => p.Toppings)
                           .Include(p => p.Sauce)
                           .AsNoTracking()
                           .SingleOrDefault(p => p.Id == id);
        }

        public Pizza? Create(Pizza newPizza)
        {
            _context.Pizzas.Add(newPizza);
            _context.SaveChanges();

            return newPizza;
        }

        public void AddTopping(int PizzaId, int ToppingId)
        {
            var pizzaToUpdate = _context.Pizzas.Find(PizzaId);
            var toppingToAdd = _context.Toppings.Find(ToppingId);

            if(pizzaToUpdate is null || toppingToAdd is null)
            {
                throw new NullReferenceException("Pizza or topping does not exist");
            }

            if(pizzaToUpdate.Toppings is null)
            {
                pizzaToUpdate.Toppings = new List<Topping>();
            }
            pizzaToUpdate.Toppings.Add(toppingToAdd);

            _context.Pizzas.Update(pizzaToUpdate);
            _context.SaveChanges();

        }

        public void UpdateSauce(int PizzaId, int SauceId)
        {
            var pizzaToUpdate = _context.Pizzas.Find(PizzaId);
            var sauceToUpdate = _context.Sauces.Find(SauceId);

            if(pizzaToUpdate is null || sauceToUpdate is null)
            {
                throw new NullReferenceException("Pizza or sauce does not exist");
            }
            pizzaToUpdate.Sauce = sauceToUpdate;
            _context.Pizzas.Update(pizzaToUpdate);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var pizzaToDelete = _context.Pizzas.Find(id);
            if(pizzaToDelete is null)
            {
                _context.Pizzas.Remove(pizzaToDelete);
                _context.SaveChanges();
            }
        }
    }
}
