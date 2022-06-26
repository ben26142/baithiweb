using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Pizzas = new List<Pizza> {
                    //new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy),
                    //new Pizza(2, "Margarita", 7.99M, Spiciness.None),
                    //new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot)
                    new Pizza(4, "Xe sirius", 35M, Spiciness.xe1),
                    new Pizza(5, "Xe vision", 47M, Spiciness.xe2),
                    new Pizza(6, "Xe SH mode", 60M, Spiciness.xe3),
                    new Pizza(7, "Xe Grande", 55M, Spiciness.xe4),
                    new Pizza(8, "Xe Airblade", 48M, Spiciness.xe5),
                }
             });
    }
}

