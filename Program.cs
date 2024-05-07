

using ConsoleApp3.classes;
using ConsoleApp3.Interfaces;
using ConsoleApp3.Managers;
using System.ComponentModel;


Console.WriteLine("Welcome To Restoran App");
Console.WriteLine("Firstly you Should Choice your status:");
Console.WriteLine("1.Worker");
Console.WriteLine("2.Customer");
Console.Write("Enter status:");
int status = Convert.ToInt32(Console.ReadLine());

DrinksManager drinksManagers = new DrinksManager();
MealManager mealManager = new MealManager();
FastFoodManager fastFoodManager = new FastFoodManager();
SweetsManager sweetsManager = new SweetsManager();


switch (status)
{

    case 1:
    start:
        Console.WriteLine("You can do this type of operations:");
        Console.WriteLine("1.Add Product to Menu");
        Console.WriteLine("2.Delete Product from Menu");
        Console.WriteLine("3.Update Product in Menu");
        Console.WriteLine("4.Get All");
        Console.Write("Enter Operation");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Add operation");
                Console.WriteLine("1.Add Drink");
                Console.WriteLine("2.Add Meal");
                Console.WriteLine("3.Add FastFood");
                Console.WriteLine("4.Add Sweets");
                Console.Write("Enter Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Drink Add Operation");
                        //Console.Write("Please Enter Drink Id: ");
                        int addDrinkId = drinksManagers.GetAll().Count();
                        Console.Write("Please Enter Drink Name: ");
                        string AddedDrinkName = Console.ReadLine();
                        Console.Write("Please Enter Drink Price: ");
                        int drinkPrice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"id: {addDrinkId+1} name: {AddedDrinkName} price: {drinkPrice} - drink adding");
                        Drinks newDrinks = new Drinks { Id = addDrinkId+1, Name = AddedDrinkName, Price = drinkPrice };
                        drinksManagers.Add(newDrinks);
                        break;


                    case 2:
                        Console.WriteLine("Meal Add Operation");
                        Console.Write("Please enter meal id:");
                        int addMealId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter meal Name: ");
                        string addedMealName = Console.ReadLine();
                        Console.Write("Please Enter meal Price: ");
                        int mealPrice = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter meal's indrigients: ");
                        string addedMealIndrigients = Console.ReadLine();
                        Meals newMeal = new Meals { Id = addMealId, Name = addedMealName, Price = mealPrice, Indrigients = addedMealIndrigients };
                        mealManager.Add(newMeal);
                        break;

                    case 3:
                        Console.WriteLine("FastFood Add Operation");
                        Console.Write("Please enter FastFood id:");
                        int addFastFoodId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter FastFood Name: ");
                        string addedFastFoodName = Console.ReadLine();
                        Console.Write("Please Enter FastFood Price: ");
                        int fastFoodPrice = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter FastFood's indrigients: ");
                        string addedFastFoodIndrigients = Console.ReadLine();
                        FastFood newFastFood = new FastFood { Id = addFastFoodId, Name = addedFastFoodName, Price = fastFoodPrice, Indrigients = addedFastFoodIndrigients };
                        fastFoodManager.Add(newFastFood);
                        break;

                    case 4:


                        Console.WriteLine("Sweet Add Operation");
                        Console.Write("Please Enter Sweet Id: ");
                        int addSweetId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter Drink Name: ");
                        string AddedSweetName = Console.ReadLine();
                        Console.Write("Please Enter Drink Price: ");
                        int sweetPrice = Convert.ToInt32(Console.ReadLine());
                        Sweets newSweet = new Sweets { Id = addSweetId, Name = AddedSweetName, Price = sweetPrice };
                        sweetsManager.Add(newSweet);
                        break;

                }

                Console.WriteLine("Do you want to continue? ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    goto start;
                }
                else
                {
                    break;
                }


            case 2:


                Console.WriteLine("Delete operation");
                Console.WriteLine("1.Delete drinks");
                Console.WriteLine("2.Delete meals");
                Console.WriteLine("3.Delete fastFood");
                Console.WriteLine("4.Delete sweets");


                int deleteChoice = Convert.ToInt32(Console.ReadLine());

                switch (deleteChoice)
                {
                    case 1:
                        Console.WriteLine("Please Enter drink id which you want to delete: ");
                        int deletedDrinkId = Convert.ToInt32(Console.ReadLine());
                        drinksManagers.Delete(deletedDrinkId);

                        break;

                    case 2:
                        Console.WriteLine("Please Enter meal id which you want to delete");
                        int deletedMealId = Convert.ToInt32(Console.ReadLine());
                        mealManager.Delete(deletedMealId);

                        break;

                    case 3:


                        Console.WriteLine("Please Enter fastFood id which you want to delete");
                        int deletedFastFoodId = Convert.ToInt32(Console.ReadLine());
                        fastFoodManager.Delete(deletedFastFoodId);

                        break;

                    case 4:


                        Console.WriteLine("Please Enter sweets id which you want to delete");
                        int deletedSweetId = Convert.ToInt32(Console.ReadLine());
                        sweetsManager.Delete(deletedSweetId);

                        break;

                }

                Console.WriteLine("Do you want to continue? ");
                string secondAnswer = Console.ReadLine().ToLower();
                if (secondAnswer == "yes")
                {
                    goto start;
                }
                else
                {
                    break;
                }

            case 3:
                Console.WriteLine("1.Drinks update");
                Console.WriteLine("1.Meals update");
                Console.WriteLine("1.FastFood update");
                Console.WriteLine("1.Sweets update");


                int updateChoice = Convert.ToInt32(Console.ReadLine());
                switch (updateChoice)
                {
                    case 1:
                        Console.Write("Please enter drink Id which you want to update: ");
                        int updatedDrinkId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter drink name: ");
                        string updatedDrinkName = Console.ReadLine();
                        Console.Write("Please enter drink price: ");
                        int updatedDrinkPrice = Convert.ToInt32(Console.ReadLine());

                        drinksManagers.Update(updatedDrinkId, new Drinks { Name = updatedDrinkName, Price = updatedDrinkPrice });
                        break;
                    case 2:
                        Console.Write("Please enter meal Id which you want to update: ");
                        int updatedMealId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter meal name: ");
                        string updatedMealName = Console.ReadLine();
                        Console.Write("Please enter meal price: ");
                        int updatedMealPrice = Convert.ToInt32(Console.ReadLine());

                        mealManager.Update(updatedMealId, new Meals { Name = updatedMealName, Price = updatedMealPrice });
                        break;
                    case 3:
                        Console.Write("Please enter fastFood Id which you want to update: ");
                        int updatedFastFoodId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter fastFood name: ");
                        string updatedFastFoodName = Console.ReadLine();
                        Console.Write("Please enter fastFood price: ");
                        int updatedFastFoodPrice = Convert.ToInt32(Console.ReadLine());

                        fastFoodManager.Update(updatedFastFoodId, new FastFood { Name = updatedFastFoodName, Price = updatedFastFoodPrice });
                        break;
                    case 4:
                        Console.Write("Please enter sweet Id which you want to update: ");
                        int updateSweetId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter sweet name: ");
                        string updateSweetName = Console.ReadLine();
                        Console.Write("Please enter sweet price: ");
                        int updateSweetPrice = Convert.ToInt32(Console.ReadLine());

                        sweetsManager.Update(updateSweetId, new Sweets { Name = updateSweetName, Price = updateSweetPrice });
                        break;
                }
                Console.WriteLine("Do you want to continue? ");
                string thirdAnswer = Console.ReadLine().ToLower();
                if (thirdAnswer == "yes")
                {
                    goto start;
                }
                else
                {
                    break;
                }

            case 4:
                Console.WriteLine("1.get drinks");
                Console.WriteLine("2.get meals");
                Console.WriteLine("3.get fastFoods");
                Console.WriteLine("4.get sweets");



                int getAllChoice = Convert.ToInt32(Console.ReadLine());
                switch (getAllChoice)
                {
                    case 1:
                        Console.WriteLine("Drinks:");
                        foreach (var item in drinksManagers.GetAll())
                        {
                            Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Meals:");
                        foreach (var item in mealManager.GetAll())
                        {
                            Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Indrigients}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("FastFoods:");
                        foreach (var item in fastFoodManager.GetAll())
                        {
                            Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Indrigients}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Sweets:");
                        foreach (var item in sweetsManager.GetAll())
                        {
                            Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
                        }
                        break;
                }
                Console.WriteLine("Do you want to continue? ");
                string fourthAnswer = Console.ReadLine().ToLower();
                if (fourthAnswer == "yes")
                {
                    goto start;
                }
                else
                {
                    break;
                }

        }


        break;
    case 2:

        Console.WriteLine("OUR MENU");
        Console.WriteLine("Drinks:");
        foreach (var item in drinksManagers.GetAll())
        {
            Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
        }
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Meals:");
        foreach (var item in mealManager.GetAll())
        {
            Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Indrigients}");
        }
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("FastFoods:");
        foreach (var item in fastFoodManager.GetAll())
        {
            Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Indrigients}");
        }
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Sweets:");
        foreach (var item in sweetsManager.GetAll())
        {
            Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
        }
        Console.WriteLine("-----------------------------------------------");

        break;

    default:
        Console.WriteLine("This kind of Status does not exist");
        break;
}


//Console.WriteLine(drinks);