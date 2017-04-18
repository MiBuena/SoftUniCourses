using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01.AttemptsAtReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new object();

            Type typeOfObj = obj.GetType();

            Type startUpType = typeof(Program);

            Type typeOfCat = typeof(Cat);

            //foreach (var prop in typeOfCat.GetProperties())
            //{
            //    Console.WriteLine(prop.Name + " " + prop.PropertyType.Name);
            //}

            //var fields = typeOfCat.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //foreach (var field in fields)
            //{
            //    Console.WriteLine(field.Name);
            //}


            //var cat = new Cat()
            //{
            //    Name = "Nova kotka"
            //};

            //var property = typeOfCat.GetProperty("Name");

            //Console.WriteLine(property.GetValue(cat));

            //property.SetValue(cat, "Ivan");

            //Console.WriteLine(property.GetValue(cat));

            //var constructors = typeOfCat.GetConstructors();

            //Console.WriteLine(constructors);

            //var constructor = typeOfCat.GetConstructor(new []{typeof(string), typeof(int)});

            //var method = typeOfCat.GetMethod("Hello");

            //if (method.ReturnType == typeof (void))
            //{
            //    Console.WriteLine("Test");
            //}

            //var name = typeof (Cat).GetProperties().Select(x=>new {Name = x.Name, Attrs = x.GetCustomAttributes()});

            //Console.WriteLine(name);

            Button button = new Button();

            button.Click += new EventHandler(OnButtonClick);

        }

        public static void OnButtonClick(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("OnButtonClick() event called.");
        }
    }


}
