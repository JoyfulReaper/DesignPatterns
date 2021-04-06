/*
MIT License
Copyright(c) 2021 Kyle Givler
https://github.com/JoyfulReaper
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Pizza
    {
        public string Dough { get; private set; }
        public string Sauce { get; private set; }
        public List<String> Toppings { get; private set; } = new List<string>();
        public decimal Price { get; private set; }

        public void AddTopping(string topping)
        {
            Toppings.Add(topping);
        }

        public void SetDough(string dough)
        {
            Dough = dough;
        }

        public void SetSauce(string sauce)
        {
            Sauce = sauce;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( $"Dough: {Dough}, Sauce: {Sauce}, Price ${Price} ");
            sb.AppendLine("Toppings:");
            
            foreach (var topping in Toppings)
            {
                sb.Append($"{topping}, ");
            }
           
            return sb.ToString().Substring(0, sb.Length - 2);
        }
    }
}
