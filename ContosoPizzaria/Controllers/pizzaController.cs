using System;
using pizzaServices;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ControllerPizzaria{


[ApiController]
[Route("[controller]")]
    public class PizzaController : ControllerBase{
        public PizzaController(){
        }

        [HttpGet]
        public List<Pizza> getAll(){
            return pizzaServicesClass.getAllPizzas();
        }

        [HttpGet("{id}")]
        public Pizza getIdPizza(int id){
            Pizza pizza = pizzaServicesClass.getIdPizza(id);
            return pizza;
        }

        [HttpPost]
        public Pizza AddPizza(Pizza pizza){
            pizzaServicesClass.AddPizza(new Pizza(){id = pizza.id, name = pizza.name, isGlutenFree = pizza.isGlutenFree}); 
            return pizza;
        }

        [HttpPut("{id}")]
        public void UpdatePizza(int id, Pizza pizza){
            if(id != pizza.id){
                return;
            }else{
                pizzaServicesClass.UpdatePizza(pizza);
            }
            return; 
        }

        [HttpDelete("{id}")]
        public void deletePizza(int id){
            pizzaServicesClass.DeletePizza(id);
        }
    }
}