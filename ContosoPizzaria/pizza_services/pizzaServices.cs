using System;
using System.Collections.Generic;

namespace pizzaServices{

    public class pizzaServicesClass{

        public static List <Pizza> lista_pizzas = new List <Pizza>();
        static pizzaServicesClass(){
            lista_pizzas.Add(new Pizza(){id = 1, name = "Classic Italian", isGlutenFree = false});
            lista_pizzas.Add(new Pizza(){id = 2, name = "Veggie", isGlutenFree = true});
        }

        public static List<Pizza> getAllPizzas(){
            return lista_pizzas;
        }

        public static Pizza getIdPizza(int valueOfId){
            Pizza found = null;
            foreach(Pizza el in lista_pizzas){
                if(el.id == valueOfId){
                    found = el;
                    return found;
                }
            }
            return found;
        }

        public static void AddPizza(Pizza pizza){ 
            lista_pizzas.Add(pizza);
        }

        public static void DeletePizza(int id){
            foreach(Pizza el in lista_pizzas){
                if(el.id == id){
                    lista_pizzas.Remove(el);
                }
            }
            return;
        }

        public static void UpdatePizza(Pizza pizza){
            foreach(Pizza el in lista_pizzas){
                if(el.id == pizza.id){
                    el.id = pizza.id;
                    el.name = pizza.name;
                    el.isGlutenFree = pizza.isGlutenFree;
                }
            }
        }
    }

    public class Pizza{
        public int id {get;set;}
        public string name = " ";
        public bool isGlutenFree {get;set;}
        
        public string nome{
            get{
                return this.name;
            }
            set{
                this.name = value;
            }
        }
    }
}

