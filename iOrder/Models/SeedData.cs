using iOrder.Models;

namespace iOrder.Data
{

    public static class SeedData
    {
        public static void Initialize(IOrderDbContext context)
        {
            // Look for any students.
            if (context.Restaurants.Any())
            {
                return;   // DB has been seeded
            }

            var restaurants = new Restaurant[]
            {
                new Restaurant{Name="choc cho",Address="Alexander St.",Email="chocho@g.com",Schedule="9a9p,9a9p,9a9p,9a9p,9a11p,9a2a, c", PhoneNumber="923-444-4444",CreatedOn=DateTime.Parse("2019-09-01"), Image="https://images.pexels.com/photos/735869/pexels-photo-735869.jpeg?auto=compress&cs=tinysrgb&w=600"},
                new Restaurant{Name="uchi",Address="Meredith St.",Email="uchi@g.com",Schedule="c,9a9p,9a9p,9a9p,9a9p,9a9p, c", PhoneNumber="912-233-1234",CreatedOn=DateTime.Parse("2017-09-01"), Image="https://images.pexels.com/photos/1126728/pexels-photo-1126728.jpeg?auto=compress&cs=tinysrgb&w=600"},
                new Restaurant{Name="bananza",Address="Arturo St.",Email="bza@g.com",Schedule="c,c,9a9p,9a9p,9a11p,9a2a,1p7p", PhoneNumber="934-123-6346",CreatedOn=DateTime.Parse("2018-09-01"), Image="https://images.pexels.com/photos/67468/pexels-photo-67468.jpeg?auto=compress&cs=tinysrgb&w=600"},
                new Restaurant{Name="pie plaza",Address="Martin St.",Email="pplza@g.com",Schedule="10a10p,10a10p,10a10p,10a10p,10a10p,10a10p,10a10p", PhoneNumber="934-333-6346",CreatedOn=DateTime.Parse("2018-09-01"), Image="https://images.pexels.com/photos/1566837/pexels-photo-1566837.jpeg?auto=compress&cs=tinysrgb&w=600"},
                new Restaurant{Name="gyro pouch",Address="Arturo St.",Email="ggp@g.com",Schedule="c,8a10p,8a10p,8a10p,8a10p,8a10p,c", PhoneNumber="934-543-6346",CreatedOn=DateTime.Parse("2018-09-01"), Image="https://images.pexels.com/photos/7314459/pexels-photo-7314459.jpeg?auto=compress&cs=tinysrgb&w=600"},

            };

            context.Restaurants.AddRange(restaurants);
            context.SaveChanges();

            ////if (context.Menus.Any())
            ////{
            ////    return;
            ////}

            //var menus = new Menu[]
            //{
            ////    new Menu{CourseID=1050,Title="Chemistry",Credits=3},
            //    //Choc Cho's Menus
            //    //new Menu{RestaurantId=1013,Name="Menu"},
                

            //    ////Uchi's Menus
            //    //new Menu{RestaurantId=1014,Name="Sushi"},
            //    //new Menu{RestaurantId=1014,Name="Entrees"},
              

            //    //Bananza's Menus
            //    //new Menu{MenuId=3, RestaurantId=2,Name="Breakfast "},
            //    //new Menu{MenuId=4, RestaurantId=2,Name="Lunch"},
            //    //new Menu{MenuId=5, RestaurantId=2,Name="Dinner"},

            //    ////Pie Plaza Menus
            //    //new Menu{MenuId=6, RestaurantId=3,Name="Sweet"},
            //    //new Menu{MenuId=7, RestaurantId=3,Name="Savory"},
            //    //new Menu{MenuId=8, RestaurantId=3,Name="Specialty"},
            //    //new Menu{MenuId=9, RestaurantId=3,Name="Drink Menu"},

            //    ////Gyro Pouch Menus
            //    //new Menu{MenuId=10, RestaurantId=4,Name="Main"},
            //    //new Menu{MenuId=11, RestaurantId=4,Name="Sides"},
            //    //new Menu{MenuId=12, RestaurantId=4,Name="Sweets"},


            //};

            //context.Menus.AddRange(menus);
            //context.SaveChanges();


            //if (context.Items.Any())
            //{
            //    return;
            //}

            //var items = new Item[]
            //{

            //    // IID;IM;NM;$;Av
            //    // Choc Cho items
            //    // Chocalate based desserts and items

            //    new Item {ItemId=0 , Image="https://media.istockphoto.com/id/1399203362/photo/slice-of-chocolate-cake-with-cream-filling-and-chocolate-shavings.jpg?b=1&s=170667a&w=0&k=20&c=aVuPsTtKvMhENFHXESeq264FOOjUcd0ME4MsVTIUnZI=", Name="Chocolate Cake", Price=12.34M , Available = true },
            //    new Item {ItemId=1 , Image="https://media.istockphoto.com/id/1189235789/photo/chocolate-mousse-desserts-concept.jpg?b=1&s=170667a&w=0&k=20&c=Z3agYKPLm8oRbTkf3btYpx017lJ49cHH0C8J2yhvf8g=", Name="Chocolate Mousse", Price=12.34M , Available = true  },
            //    new Item {ItemId=2 , Image="https://media.istockphoto.com/id/1346128287/photo/chocolate-fondant-cake-molten-lava-cake.jpg?b=1&s=170667a&w=0&k=20&c=s_RbtvAtNUtSNf9B-wP1V-zkt8MNe0jozMYRPGsg_9s=", Name="Chocolate Lava Cake", Price=12.34m , Available = true  },
            //    new Item {ItemId=4, Image="https://media.istockphoto.com/id/1045317014/photo/chocolate-truffle-balls-with-melted-chocolate.jpg?b=1&s=170667a&w=0&k=20&c=iZCByYbIJIoZjDxhj4y3lVakvNefPrDEhyH_ql8FWfo=", Name="Chocolate Truffles", Price=12.34m , Available = true  },
            //    new Item {ItemId=5 , Image="https://media.istockphoto.com/id/172453684/photo/ready-to-eat-cheesecake-chocolate.jpg?b=1&s=170667a&w=0&k=20&c=JvyfWFTCdX68rUKKyrRGQFUpsWyW0haYl0htwT8pEIQ=", Name="Chocolate Cheesecake", Price=12.34m , Available = true  },
            //    new Item {ItemId=6 , Image="https://media.istockphoto.com/id/648869074/photo/chocolate-fondue-with-fruits.jpg?b=1&s=170667a&w=0&k=20&c=oASE6uEe8Ev0mKfoem-WfInRTJpIhT_sSRlAkbTeQaw=", Name="Chocolate Fondue", Price= 12.34m, Available = true  },
            //    new Item {ItemId=7 , Image="https://media.istockphoto.com/id/1255426185/photo/delicious-chocolate-zucchini-brownies.jpg?b=1&s=170667a&w=0&k=20&c=WZajVWSpzMGwJAOw9bbS5n00N9_28pI83SOrCVMWpkY=", Name="Brownie", Price= 12.34m, Available = true  },
            //    new Item {ItemId=8 , Image="https://media.istockphoto.com/id/1385521869/photo/chef-preparing-a-chocolate-mousse-dessert.jpg?b=1&s=170667a&w=0&k=20&c=irJwh8R-Q3MQCAebotL79gFHVAQzoDi8LSgW87xZWN8=", Name="Fudge", Price=12.34m , Available = true  },
            //    new Item {ItemId=9 , Image="https://media.istockphoto.com/id/1392972250/photo/chocolate-chunk-cookies.jpg?b=1&s=170667a&w=0&k=20&c=TFGiQMmUYbo334Otnpzb6IgGsdmt5nJglWtyF1pZGe8=", Name="Chocolate Chip Cookie", Price= 12.34m, Available = true  },
            //    new Item {ItemId=10 , Image="https://media.istockphoto.com/id/180811737/photo/chocolate-mousse.jpg?b=1&s=170667a&w=0&k=20&c=yHCVyN1ojFwJ8czmA3ljfbQm1d4fh-Hrlm1NGiRlMUM=", Name="Chocolate Pudding", Price=12.34m , Available = true  },
            //    new Item {ItemId=11 , Image="https://media.istockphoto.com/id/1330613157/photo/cream-puff-with-custard-cream-covered-with-melted-chocolate.jpg?b=1&s=170667a&w=0&k=20&c=DuY43-sc4694kQzzN6vUX-f2Cw1N8jkNxOGrevqwSfM=", Name="Chocolate Eclair", Price=12.34m , Available = true  },
            //    new Item {ItemId=12 , Image="https://media.istockphoto.com/id/669712338/photo/chocolate-covered-strawberries.jpg?b=1&s=170667a&w=0&k=20&c=SCzDJg2jeofcth4ni5zBB4xcMBt4id5T1JwNgSvkfR8=", Name="Chocolate-covered Strawberries", Price=12.34m , Available = true  },
            //    new Item {ItemId=13 , Image="https://media.istockphoto.com/id/175393830/photo/chocolate-ice-cream.jpg?b=1&s=170667a&w=0&k=20&c=1ocJmZm793mla5dO_liICagkUH9PtvuZcdsBJx5mrKY=", Name="Chocolate Ice Cream", Price=12.34m , Available = true  },
            //    new Item {ItemId=14 , Image="https://media.istockphoto.com/id/1351872663/photo/homemade-chocolate-ganache-tart-with-figs-and-pistachios.jpg?b=1&s=170667a&w=0&k=20&c=xQPXWCpu75J31JE8HdrTsb4mEqaE9UmdkN4Pfz_urGw=", Name="Chocolate Ganache Tart", Price=12.34m , Available = true },
            //    new Item {ItemId=15 , Image="https://media.istockphoto.com/id/515656978/photo/chocolate-souffle.jpg?b=1&s=170667a&w=0&k=20&c=xTMc8rl_ifY3MnrMr94hyuZfB20n0mq6yL_I4cnzwU4=", Name="Chocolate Souffle", Price=12.34m , Available = true  },
            //    new Item {ItemId=16 , Image="https://media.istockphoto.com/id/176789242/photo/chocolate-bread-and-butter-pudding-plate-plated.jpg?b=1&s=170667a&w=0&k=20&c=zIBBbpFKY6X3PCzETxGMWEbFZ2gk8_GGFsSM4EhPFno=", Name="Chocolate Bread Pudding", Price=12.34m , Available = true   },
            //    new Item {ItemId=17 , Image="https://media.istockphoto.com/id/853400990/photo/macarons-sweet-chocolate-macaron-french-on-wooden-table.jpg?b=1&s=170667a&w=0&k=20&c=TS2Cy20pHJeuaFteMtc7MWhbPS75Tf-TW00_YxATphI=", Name="Chocolate Macaron", Price= 12.34m, Available = true   },
            //    new Item {ItemId=18 , Image="https://media.istockphoto.com/id/899701500/photo/chocolate-covered-cherries.jpg?b=1&s=170667a&w=0&k=20&c=Et4uCKy0zWIKM6j0-q-yGGToiMuKgeaNQUYS1UOSmtE=", Name="Chocolate Cherry Cordials", Price=12.34m , Available = true   },
            //    new Item {ItemId=19 , Image="https://media.istockphoto.com/id/529129491/photo/homemade-chocolate-covered-pretzels.jpg?b=1&s=170667a&w=0&k=20&c=o9OATZWpeBNM1GqVtV7tfkDTDZSbIPaMspwX6fzdpe0=", Name="Chocolate-dipped Pretzels", Price=12.34m , Available = true },
            //    new Item {ItemId=20 , Image="https://media.istockphoto.com/id/1409650395/photo/delicious-almond-croissant-on-metal-grate.jpg?b=1&s=170667a&w=0&k=20&c=cNpDFPwaZeILiAEEULMI5XF5UkEH5qQOWR3xVUjCPGA=", Name="Chocolate Almond Croissant", Price=12.34m , Available = true  },
            //    new Item {ItemId=21 , Image="https://media.istockphoto.com/id/185218448/photo/chocolate-croissants.jpg?b=1&s=170667a&w=0&k=20&c=T5_offvLOwh7jkE7cQJ_nf3c1wX27BczfeNUrI_sqWQ=", Name="Chocolate Croissant", Price=12.34m , Available = true   },
            //    new Item {ItemId=22 , Image="https://media.istockphoto.com/id/1183046933/photo/chocolate-swirl-bread.jpg?b=1&s=170667a&w=0&k=20&c=E2EU7jXVqLyBYnJAt2N6saK5UgDrzf2SLgGtKfdLTGA=", Name="Chocolate Babka", Price=12.34m , Available = true   },
            //    new Item {ItemId=23 , Image="https://media.istockphoto.com/id/508514698/photo/gourmet-chocolate-bark.jpg?b=1&s=170667a&w=0&k=20&c=SpUhw3SdVAe4-p9NCstrHfOH5X6RDyFkjuFiZIl0RRw=", Name="Chocolate Pecan Crisps", Price=12.34m , Available = true  },
            //    new Item {ItemId=24 , Image="https://media.istockphoto.com/id/1034198714/photo/luxury-handmade-chocolate-on-black-background.jpg?b=1&s=170667a&w=0&k=20&c=55PTXccTnyYLsiQJAaAQi16zFsnqrqkfh3rUBI3Vii8=", Name="Chocolate Bark", Price=12.34m , Available = true  },

            //    //Uchi items
            //    //Sushi and Japanese food
            //    new Item {ItemId=25 , Image="https://media.istockphoto.com/id/1479809733/photo/hand-roll-with-salmon-and-tuna-on-a-dark-background.jpg?b=1&s=170667a&w=0&k=20&c=MN0QYIHgxrAqKifEdkuttfNwHTRBrv24mwsYfPLk2CA=", Name="California Roll", Price=12.34m , Available = true   },
            //    new Item {ItemId=26 , Image="https://media.istockphoto.com/id/1390159605/photo/fresh-sushi-rolls.jpg?b=1&s=170667a&w=0&k=20&c=gk5FJCxe800HC2UywHquW8saeN281FwltteZnWvIasE=", Name="Philadelphia Roll", Price= 12.34m, Available = true   },
            //    new Item {ItemId=27 , Image="https://images.unsplash.com/photo-1564489563601-c53cfc451e93?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTl8fENydW5jaHklMjBSb2xsJTIwc3VzaGl8ZW58MHx8MHx8&auto=format&fit=crop&w=800&q=60", Name="Spicy Tuna Roll", Price=12.34m , Available = true  },
            //    new Item {ItemId=28 , Image="https://images.unsplash.com/photo-1617196035154-1e7e6e28b0db?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjB8fENydW5jaHklMjBSb2xsJTIwc3VzaGl8ZW58MHx8MHx8&auto=format&fit=crop&w=800&q=60", Name="Dragon Roll", Price=12.34m , Available = true   },
            //    new Item {ItemId=29 , Image="https://media.istockphoto.com/id/1414311369/photo/oba-roll-crispy-salmon-avocado-topped-with-salmon-parrillera-jalape%C3%B1o-sauce-chalaquita.jpg?b=1&s=170667a&w=0&k=20&c=fQQamaB4PpoLNFUsJXkh0SXeiqGYt9eo6LCUf7NWDBU=", Name="Rainbow Roll", Price=12.34m , Available = true   },
            //    new Item {ItemId=30 , Image="https://images.unsplash.com/photo-1617196034796-73dfa7b1fd56?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTh8fENydW5jaHklMjBSb2xsJTIwc3VzaGl8ZW58MHx8MHx8&auto=format&fit=crop&w=800&q=60", Name="Spider Roll", Price=12.34m , Available = true   },
            //    new Item {ItemId=31 , Image="https://images.unsplash.com/photo-1579584425555-c3ce17fd4351?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fENydW5jaHklMjBSb2xsJTIwc3VzaGl8ZW58MHx8MHx8&auto=format&fit=crop&w=800&q=60", Name="Caterpillar Roll", Price=12.34m , Available = true   },
            //    new Item {ItemId=32 , Image="https://media.istockphoto.com/id/183876322/photo/eel-roll.jpg?b=1&s=170667a&w=0&k=20&c=IB3poDDhpBcjAs6HwiXjcjk9ZvivFk21sol47wSyQ3E=", Name="Alaska Roll", Price=12.34m , Available = true   },
            //    new Item {ItemId=33 , Image="https://media.istockphoto.com/id/1134975581/photo/new-york-crunch-sushi-roll.jpg?b=1&s=170667a&w=0&k=20&c=TkumyshQE__y4C5zLjzaObekO8G_D3AHsfdy0ST03hk=", Name="Boston Roll", Price=12.34m , Available = true   },
            //    new Item {ItemId=34 , Image="https://media.istockphoto.com/id/186868457/photo/uramaki-sushi.jpg?b=1&s=170667a&w=0&k=20&c=MHFqEvxSvZPotUdiwmlmw6-EjvwPDBWrqttRDGtps6Y=", Name="Tempura Roll", Price=12.34m , Available = true   },
            //    new Item {ItemId=35 , Image="https://media.istockphoto.com/id/183815946/photo/shrimp-tempura-roll.jpg?b=1&s=170667a&w=0&k=20&c=LkOLA51gI4gnDg0UZW9aBBfYtqit4X8kI40oKfHM_Kw=", Name="Crunchy Roll", Price=12.34m , Available = true   },
            //    new Item {ItemId=36 , Image="https://media.istockphoto.com/id/495116260/photo/sushi.jpg?b=1&s=170667a&w=0&k=20&c=FyoFVOsSUb7yH-V-QVyTf01qlpXXFErGAgc5b13ejzM=", Name="Veggie Roll", Price=12.34m , Available = true },
            //    new Item {ItemId=37 , Image="https://media.istockphoto.com/id/1365977387/photo/ramen-with-steaming-sizzle.jpg?b=1&s=170667a&w=0&k=20&c=8iOcgakOhguZ67D_dSUhMF5cAG_mgHBV8yiz1K74EFU=", Name="Ramen", Price=12.34m , Available = true  },
            //    new Item {ItemId=38 , Image="https://media.istockphoto.com/id/900427426/photo/fried-shrimps-tempura-with-sweet-chili-sauce-on-white-wooden-board.jpg?b=1&s=170667a&w=0&k=20&c=nIv8z-Z9YpHKBZcYoG2sZP-9JJyqUqIlNp8xMbiDhYo=", Name="Chicken Tempura", Price=12.34m , Available = true  },
            //    new Item {ItemId=39 , Image="https://media.istockphoto.com/id/1203444561/photo/japanese-okonomiyaki-recipe-sprinkle-sauce-mayonnaise-seaweed-and-bonito-on-okonomiyaki.jpg?b=1&s=170667a&w=0&k=20&c=l_IhmpgoXjAdz3lR1cEvVMm9-gBYWm1ehpcIeMm964Q=", Name="Okonomiyaki", Price=12.34m , Available = true   },
            //    new Item {ItemId=40 , Image="https://media.istockphoto.com/id/1439755708/photo/chinese-fried-noodles-with-chicken-and-vegetables-in-ceramic-bowl-on-black-concrete.jpg?b=1&s=170667a&w=0&k=20&c=NJI3ln0NI2Opyxl1sCY71sEhkK6geK1AFUjOa0nrafQ=", Name="Udon", Price=12.34m , Available = true   },
            //    new Item {ItemId=41 , Image="https://media.istockphoto.com/id/1448378347/photo/kebabs-grilled-meat-skewers-shish-kebab-on-old-dark-wooden-table-background.jpg?b=1&s=170667a&w=0&k=20&c=zEWSqRq5SBlyCO2_H0B3rxTD6pnFUzyX7nJg6sUVlls=", Name="Yakitori", Price=12.34m , Available = true   },
            //    new Item {ItemId=42 , Image="https://media.istockphoto.com/id/695325508/photo/panko-crusted-crispy-pork-cutlets-over-steamed-rice.jpg?b=1&s=170667a&w=0&k=20&c=gRU6eBRCe_wnmRMkYMQO84hJkUNQOs-SjxhE7cSOh98=", Name="Tonkatsu", Price=12.34m , Available = true   },
            //    new Item {ItemId=43 , Image="https://media.istockphoto.com/id/696145966/photo/delicious-bulgogi-marinated-in-soy-sauce-and-garlic-and-ginger-over-steamed-rice.jpg?b=1&s=170667a&w=0&k=20&c=6tHomYJ0cGWUlFsEl5yMT2ZJP9o2yqqF7HMwM-e8X8s=", Name="Donburi", Price=12.34m , Available = true  },
            //    new Item {ItemId=44 , Image="https://images.unsplash.com/photo-1556906851-99df9cb88ad2?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8U2hhYnUlMjBzaGFidXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=700&q=60", Name="Shabu-shabu", Price=12.34m , Available = true  },
            //    new Item {ItemId=45 , Image="https://media.istockphoto.com/id/1372815761/photo/soba-noodles-with-sesame-coriander-and-soy-sauce.jpg?b=1&s=170667a&w=0&k=20&c=9TnqMZyqINj1Ajq1V9wt4mODW50dns8m7VbTum6vkiI=", Name="Soba", Price=12.34m , Available = true   },
            //    new Item {ItemId=46 , Image="https://media.istockphoto.com/id/650197112/photo/miso-soup.jpg?b=1&s=170667a&w=0&k=20&c=QlCfLcXry86aB92Hbj6XJhuiTAAtJ0IYP7dSDpVE4H8=", Name="Miso Soup", Price=12.34m , Available = true   },
            //    new Item {ItemId=47 , Image="https://media.istockphoto.com/id/1340125616/photo/takoyaki-on-a-white-background.jpg?b=1&s=170667a&w=0&k=20&c=yf1zDQvlhHfq3sTPQj82h5HLB5HPYcwQqogAoHY0FWA=", Name="Takoyaki", Price=12.34m , Available = true   },
            //    new Item {ItemId=48 , Image="https://media.istockphoto.com/id/1309978297/photo/asian-food-gyoza-or-jiaozi-fried-dumplings.jpg?b=1&s=170667a&w=0&k=20&c=DLt96-5Syhbay-TkV9m1Q1HezrP-hlEaIYM2oV1t_YI=", Name="Gyoza", Price= 12.34m, Available = true   },

            //    //Bananza items
            //    //Chuck Wagon 
            //    new Item {ItemId=49 , Image="https://plus.unsplash.com/premium_photo-1661424134119-4a5d544af771?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8RWdncyUyMGFuZCUyMEJhY29ufGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=700&q=60", Name="Eggs and Bacon", Price=12.34m, Available = true  },
            //    new Item {ItemId=50 , Image="https://media.istockphoto.com/id/505862736/photo/breakfast-with-sunny-side-up-eggs-and-sausage.jpg?b=1&s=170667a&w=0&k=20&c=YFM82m_2Yk04Je7YPvTBeYA_DzH784V5JFkoY2fYD9w=", Name="Eggs and Sausage", Price=12.34m , Available = true  },
            //    new Item {ItemId=51 , Image="https://media.istockphoto.com/id/1325291150/photo/ham-and-cheese-omelet.jpg?b=1&s=170667a&w=0&k=20&c=CYcgnmYwlxayfmHlPGRomeXTivNbqxhDi0RaCtVykJE=", Name="Ham and Cheese Omelette", Price= 12.34m, Available = true  },
            //    new Item {ItemId=52 , Image="https://media.istockphoto.com/id/1330604424/photo/macro-closeup-side-view-of-stack-of-buttermilk-pancakes-on-plate-as-traditional-breakfast.jpg?b=1&s=170667a&w=0&k=20&c=LTEp5V3tgPEoDSZCGF1-ykSftPN_4eXY-SaXKDTrqJY=", Name="Pancakes", Price=12.34m , Available = true  },
            //    new Item {ItemId=53 , Image="https://media.istockphoto.com/id/157617841/photo/pancakes.jpg?b=1&s=170667a&w=0&k=20&c=cdt20n_bP9PTc2hENoQ7pKhQht_cDNR2LVakYVr5UPk=", Name="Chocolate Chip Pancakes", Price=12.34m , Available = true  },
            //    new Item {ItemId=54 , Image="https://media.istockphoto.com/id/1161996776/photo/stack-of-pancakes-with-maple-syrup-and-fresh-blueberries.jpg?b=1&s=170667a&w=0&k=20&c=Q6BDtDtY5rTNWkiGQydVctdafv2rZh3V2MWL8UmDR04=", Name="Blueberry Pancakes", Price=12.34m , Available = true  },
            //    new Item {ItemId=55 , Image="https://media.istockphoto.com/id/672113616/photo/french-toast-with-maple-syrup-and-berries.jpg?b=1&s=170667a&w=0&k=20&c=omlrhUy2E0hh0Tv6WK7G21uzuTwVX1D1VsM3cNU9IMg=", Name="French Toast", Price=12.34m , Available = true  },
            //    new Item {ItemId=56 , Image="https://media.istockphoto.com/id/155359449/photo/savory-breakfast-casserole.jpg?b=1&s=170667a&w=0&k=20&c=VLZTGONfcIeN4wrUB9w9SrDqlQmsUnItllURqbdSX4Q=", Name="Breakfast Casserole", Price=12.34m , Available = true  },
            //    new Item {ItemId=57 , Image="https://media.istockphoto.com/id/1316455848/photo/fresh-salad-with-tomato-cucumber-vegetables-microgreen-radishes-in-white-plate-on-grey-stone.jpg?b=1&s=170667a&w=0&k=20&c=NBWfEjnx65Dubx5Quv7Y_kkbxj590cvwRGPyKZXLIxo=", Name="House Salad", Price=12.34m , Available = true  },
            //    new Item {ItemId=58 , Image="https://media.istockphoto.com/id/169986941/photo/chicken-salad.jpg?b=1&s=170667a&w=0&k=20&c=sLnGzphC2t2m-TULdfhuVHbmKsvb-LNMacn3KhI4lzc=", Name="Grilled Chicken Salad", Price=12.34m , Available = true  },
            //    new Item {ItemId=59 , Image="https://images.unsplash.com/photo-1626645738196-c2a7c87a8f58?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8RnJpZWQlMjBDaGlja2VufGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=700&q=60", Name="Country Fried Chicken", Price=12.34m , Available = true  },
            //    new Item {ItemId=60 , Image="https://media.istockphoto.com/id/182893181/photo/a-plate-of-fried-chicken-mashed-potatoes-and-asparagus.jpg?b=1&s=170667a&w=0&k=20&c=qzGjZbcwJYxWAjvpdPCT7FDpPt7YfhhSI0JzOp0JTw0=", Name="Country Fried Steak", Price=12.34m , Available = true  },
            //    new Item {ItemId=61 , Image="https://media.istockphoto.com/id/1369335084/photo/sunday-pot-roast.jpg?b=1&s=170667a&w=0&k=20&c=bZ8dkhs_M2CsgxylpykdLgGn_a1mW4xX2hrNVmEzv_M=", Name="Pot Roast", Price=12.34m , Available = true  },
            //    new Item {ItemId=62 , Image="https://media.istockphoto.com/id/1144164083/photo/roasted-tomato-garlic-and-basil-soup-with-grilled-cheese-croutons.jpg?b=1&s=170667a&w=0&k=20&c=OXuRtwaXMbexcwck_MZkpwgtmEeIMwZlKBrHjdGaTEs=", Name="Tomato Soup", Price=12.34m , Available = true  },
            //    new Item {ItemId=63 , Image="https://media.istockphoto.com/id/1308147038/photo/creamy-chicken-and-dumplings.jpg?b=1&s=170667a&w=0&k=20&c=WUm5qA2klvTB3427kq_90B-ShaAbPsX4Uf0PLPG_Rbs=", Name="Chicken and Dumplings", Price=12.34m , Available = true  },
            //    new Item {ItemId=64 , Image="https://media.istockphoto.com/id/1290313284/photo/creamy-baked-potato-soup-with-cheddar-cheese-green-onions-and-crispy-bacon.jpg?b=1&s=170667a&w=0&k=20&c=K2XV5qmInm9qiOYeuW8OUg01TMzfliTGDgpMxPUsIEI=", Name="Potato Soup", Price=12.34m , Available = true  },
            //    new Item {ItemId=65 , Image="https://media.istockphoto.com/id/1315023820/photo/cheesy-spinach-stuffed-pork-chops.jpg?b=1&s=170667a&w=0&k=20&c=FN5cJL4yX27CsoJn42V3uCR7ezBf5a7Dk0LnIU6NmiU=", Name="Baked Pork Chop", Price=12.34m , Available = true  },
            //    new Item {ItemId=66 , Image="https://media.istockphoto.com/id/531469196/photo/chicken-thighs.jpg?b=1&s=170667a&w=0&k=20&c=gihRk1sndG-SViqcAjiowal0xsc03WrpaSUzFMmTGr4=", Name="Baked Chicken", Price=12.34m , Available = true  },
            //    new Item {ItemId=67 , Image="https://media.istockphoto.com/id/1086378976/photo/medium-rare-fillet-mignon-steak-with-herb-garlic-butter.jpg?b=1&s=170667a&w=0&k=20&c=YTybijNmI0nHE_A-LRVPw2FUi9f98HH4UtCqbplicpM=", Name="Filet Mignon", Price=12.34m , Available = true  },
            //    new Item {ItemId=68 , Image="https://media.istockphoto.com/id/1371751060/photo/grilled-medium-rare-top-sirloin-beef-steak-or-rump-steak-on-a-steel-tray-dark-background-top.jpg?b=1&s=170667a&w=0&k=20&c=-Vc6g0zdRZIx1w38gddVmd2t5TIZlpZo0XzxTW9tBoo=", Name="Sirloin", Price=12.34m , Available = true  },
            //    new Item {ItemId=69 , Image="https://media.istockphoto.com/id/185266036/photo/steak-dinner.jpg?b=1&s=170667a&w=0&k=20&c=-hToWJp3D-v26jN93rdXXFmrWopXvmVdTnTK5JBhUks=", Name="Porter House", Price=12.34m , Available = true  },
            //    new Item {ItemId=70 , Image="https://images.unsplash.com/photo-1556269923-e4ef51d69638?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8TmV3JTIwWW9yayUyMFN0cmlwJTIwY29va2VkfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=700&q=60", Name="T-Bone", Price=12.34m , Available = true  },
            //    new Item {ItemId=71 , Image="https://images.unsplash.com/photo-1644704265419-96ddaf628e71?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8TmV3JTIwWW9yayUyMFN0cmlwfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=700&q=60", Name="New York Strip", Price=12.34M , Available = true  },
            //    new Item {ItemId=72 , Image="https://media.istockphoto.com/id/587207508/photo/sliced-grilled-steak-ribeye-with-herb-butter.jpg?b=1&s=170667a&w=0&k=20&c=avY4SSBVEmR1knsI1QG0v-iowbX1PC1xJbZIZqShttA=", Name="Ribeye", Price=12.34M  , Available = true  },

            //    //Pie Plaza items
            //    // All types of pies
            //    new Item {ItemId=73 , Image="https://media.istockphoto.com/id/450752471/photo/homemade-organic-apple-pie-dessert.jpg?b=1&s=170667a&w=0&k=20&c=Y0SisNtd6vLbMLtxqr5ZK4kumKX4z1sPpIDzKHvOQUE=", Name="Apple Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 74, Image="https://media.istockphoto.com/id/1350752965/photo/pumpkin-pie-with-whipped-cream.jpg?b=1&s=170667a&w=0&k=20&c=BhiQXcD2WS49g--35rKM1SIfqJYOWAYrqsQianL6WpA=", Name="Pumpkin Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 75, Image="https://media.istockphoto.com/id/172410532/photo/pecan-pie-fresh-baked-holiday-dessert-with-ingredients-rolling-pin.jpg?b=1&s=170667a&w=0&k=20&c=VLCemDmt4EihH2B3RrXf9rOMQpPkqHJoyXQQWzYNCac=", Name="Pecan Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 76, Image="https://media.istockphoto.com/id/509171669/photo/delicious-homemade-cherry-pie.jpg?b=1&s=170667a&w=0&k=20&c=Oo6AIm-F71J6UtNLS1NCD1P8Q82Pcon8qsJ32qBas9Q=", Name="Cherry Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId=77 , Image="https://media.istockphoto.com/id/1223139298/photo/high-angle-photograph-of-a-lattice-fruit-pie.jpg?b=1&s=170667a&w=0&k=20&c=h8qobZMWLPSf8-vXb5EzUs3PT7obfiNrwNCsQ0apJdQ=", Name="Blueberry Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 78, Image="https://media.istockphoto.com/id/1284788262/photo/key-lime-pie.jpg?b=1&s=170667a&w=0&k=20&c=1K2VRlBqFG_tSQW_KtwHKmvarIU0EUHs_VrRe_ZBf8Q=", Name="Key Lime Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId=79 , Image="https://media.istockphoto.com/id/905197646/photo/traditional-british-shepards-pie.jpg?b=1&s=170667a&w=0&k=20&c=puO_q3LW-3k2-5_vLnM7amucD3CS4fgeM1cLrQlf2D4=", Name="Shepard's Pie", Price= 12.34M , Available = true  },
            //    new Item {ItemId= 80, Image="https://media.istockphoto.com/id/532315715/photo/chicken-pot-pie.jpg?b=1&s=170667a&w=0&k=20&c=V491Qzu5a7C9ptnmxEfTrzTcml-L2ivJgx5FHs1BU0U=", Name="Chicken Pot Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId=81 , Image="https://media.istockphoto.com/id/1372181885/photo/golden-organic-healthy-crispy-pie-with-artichokes-dried-tomatoes-and-olives-on-the-table.jpg?b=1&s=170667a&w=0&k=20&c=cennbQwDMgIP9i9KIW8vWENeGFMyldZvsVTKw6FL_s4=", Name="Quiche", Price= 12.34M , Available = true  },
            //    new Item {ItemId=82 , Image="https://media.istockphoto.com/id/499188451/photo/slice-of-meat-pie-tourtiere.jpg?b=1&s=170667a&w=0&k=20&c=te2W6MeJJm5duQE4D79YF_BtjfwAzaF5a872OnIU5js=", Name="Tourtiere", Price= 12.34M , Available = true  },
            //    new Item {ItemId= 83, Image="https://media.istockphoto.com/id/134250449/photo/mini-pizzas.jpg?b=1&s=170667a&w=0&k=20&c=bDfN_Z3_abHAJRRzeXsMgROXwskfesXneseLFeC9xXM=", Name="Pissaladiere", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 84, Image="https://media.istockphoto.com/id/1373003806/photo/pasties-filled-with-meat-and-vegetables.jpg?b=1&s=170667a&w=0&k=20&c=hJy9AB_F5lJnltARR3I7mB-H2yQsZ3b7q1iFPIFB3OA=", Name="Cornish Pasty", Price= 12.34M , Available = true  },
            //    new Item {ItemId= 85, Image="https://media.istockphoto.com/id/1447879875/photo/profiteroles-with-pistachio-in-glass-bowl.jpg?b=1&s=170667a&w=0&k=20&c=6iS2Uf2bRghNcC5h8K62Sr5JjNyGcS44Rz8Xe4zb090=", Name="Croquembouche", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 86, Image="https://media.istockphoto.com/id/1158691645/photo/homemade-toasted-baked-alaska.jpg?b=1&s=170667a&w=0&k=20&c=9DAdSHvKvuKALGral5p2XaXk5BqCPW1sUKKiGVQJAqM=", Name="Baked Alaska", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 87, Image="https://media.istockphoto.com/id/1253747247/photo/chocolate-souffles.jpg?s=612x612&w=0&k=20&c=s4YCLQv6baqqYHafGbk6NB3tjKxjdm61dicES5wzRhc=", Name="Chocolate Souffle Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 88, Image="https://media.istockphoto.com/id/671806706/photo/lime-yoghurt-olive-oil-cake.jpg?s=612x612&w=0&k=20&c=7fsKyZRDliF-EHcT3QYhRck0W4T7o4uaW37Ga41cpe0=", Name="Lemon Sponge Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 89, Image="https://dessertsonadime.com/wp-content/uploads/2022/11/1200-x-1800-Cinnamon-Roll-Pie-21-683x1024.jpg.webp", Name="Cinnamon Roll Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId=90 , Image="https://d1yfn1dfres2va.cloudfront.net/006/36/50/36500e6e4b76111c6a3f26f6ebe71988_640m.jpg", Name="Blackberry Swirl Pie", Price=12.34M  , Available = true  },
            //    new Item {ItemId=91 , Image="https://media.istockphoto.com/id/1281122491/photo/homemade-frozen-vanilla-milkshake.jpg?s=612x612&w=0&k=20&c=2l1GD_rg1k0HawUhBJWkRXmIsyBUe0khPXmWRt-MPGo=", Name="Vanilla Shake", Price= 12.34M , Available = true  },
            //    new Item {ItemId=92 , Image="https://media.istockphoto.com/id/504639970/photo/strawberry-milkshake.jpg?s=612x612&w=0&k=20&c=64bfa23BLQjavfIGMGy-5UlPIklIj_ZdnaXqy7BGx8Q=", Name="Strawberry Shake", Price=12.34M  , Available = true  },
            //    new Item {ItemId=93 , Image="https://media.istockphoto.com/id/477482332/photo/classic-glass-of-chocolate-milkshake-on-white-backdrop.jpg?s=612x612&w=0&k=20&c=wA79ixRo5SmZLRYfKC0Ya7a8nbDjeeVHxcVyJb8UoA0=", Name="Chocolate Shake", Price=12.34M  , Available = true  },
            //    new Item {ItemId=94 , Image="https://media.istockphoto.com/id/1457350328/photo/delicious-strawberry-ice-cream-sundae-on-vintage-blue-and-yellow-background.jpg?s=612x612&w=0&k=20&c=xP0yW30E_LphML_5iU_Wq5IKeozxaF28SpWJW8wWp3E=", Name="Neapolitan Shake", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 95, Image="https://media.istockphoto.com/id/1194152250/photo/vegan-banana-and-oatmeal-smoothie-in-glass-jar-on-the-light-background.jpg?s=612x612&w=0&k=20&c=np9DgHLFcUJwY5hzLd3aSLzebaYDzPzerkEGbuGy0tY=", Name="Banana Shake", Price= 12.34M , Available = true  },
            //    new Item {ItemId=96 , Image="https://media.istockphoto.com/id/1255401209/photo/glass-with-strawberry-smoothie-or-milkshake.jpg?s=612x612&w=0&k=20&c=hgognYCh-DQ5aw9XrPyZOg8XeRctG2DK5csLCQParZs=", Name="Strawberry Shake", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 97, Image="https://media.istockphoto.com/id/1007480178/photo/homemade-hot-chocolate-with-mini-marshmallow.jpg?s=612x612&w=0&k=20&c=JvS8UBQZA0QCGQ8jlUi1_6fK6127Dky5uc-fWt6ohnc=", Name="Hot Chocolate ", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 98 , Image="https://media.istockphoto.com/id/1326143969/photo/bowl-with-vanilla-ice-cream-balls.jpg?s=612x612&w=0&k=20&c=WxEriNEK7yW7F4AWImLQRrpco-R_bdDYEQoyhigu9fc=", Name="Vanilla Ice Cream", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 99, Image="https://media.istockphoto.com/id/936155834/photo/belgian-chocolate-ice-creams.jpg?s=612x612&w=0&k=20&c=EswLAE2HGNpt-3Fv5q74--M5KwLxkSFqub3_6MgP5h4=", Name="Chocolate Ice Cream", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 100 , Image="https://media.istockphoto.com/id/678771308/photo/strawberry-cream-ice-cream-in-white-bowl.jpg?s=612x612&w=0&k=20&c=R40uMRzbRhodlqXud5QaJnFCzLMOScxzS6ZxbPS_4tc=", Name="Strawberry Ice Cream", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 101 , Image="https://media.istockphoto.com/id/1128466907/photo/neapolitan-ice-cream-scoops-in-white-ceramics-bowl.jpg?s=612x612&w=0&k=20&c=Rcv27co9ttx-Ce1uF64294jbZ1tgJM4EUo97bCSMixg=", Name="Neapolitan Ice Cream", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 102, Image="https://media.istockphoto.com/id/1064447008/photo/summer-berry-cake-with-raspberry-berries-currants-and-blueberries-close-up-in-a-baking-dish.jpg?s=612x612&w=0&k=20&c=BMe5nL1ZltJxfZ78MXXHWKsO1XD3q5yWzv1qoSJVTgk=", Name="Mixed Fruit Cobbler", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 103, Image="https://media.istockphoto.com/id/1191590289/photo/banoffee-pie-cakes-delicious-bananas-cake-whipped-cream.jpg?s=612x612&w=0&k=20&c=LAwjYQDSeO7-14D0ct3TzvlGmVhn9Trs9flQQ0b8Ycc=", Name="Baked Banana Pudding", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 104, Image="https://media.istockphoto.com/id/1248489319/photo/tiramisu-cake-with-mint.jpg?s=612x612&w=0&k=20&c=bE6ntOpTO7S8T_Rr39cnNkV_252VUB8-vymkN9WsQRQ=", Name="Tiramisu", Price=12.34M  , Available = true  },

            //    //Gyro Pouch items
            //    //gyros and greek food 

            //    new Item {ItemId= 105, Image="https://media.istockphoto.com/id/697316476/photo/two-greek-gyros-with-shaved-lamb-and-french-fries.jpg?s=612x612&w=0&k=20&c=phcB1a2SBMIXLgzFQKMJekAA5032iLXNvSXOP2R71TQ=", Name="Lamb Gyro", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 106, Image="https://media.istockphoto.com/id/1307560476/photo/gyros-with-beef-on-the-board-on-white-concrete-table-greek-cuisine.jpg?s=612x612&w=0&k=20&c=Ai5kVnLYjqpqgSgSVCYelOVG2F8xGIefygR1QyJPijk=", Name="Beef Gyro", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 107, Image="https://media.istockphoto.com/id/1335959521/photo/homemade-stuffed-pita-bread-with-gyros-d%C3%BCr%C3%BCm-d%C3%B6ner.jpg?s=612x612&w=is&k=20&c=ZH6-q9UKYPVei4bfomEAT8iZWTbYrHs6L8yOsY-3EWo=", Name="Veggie Gyro", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 108, Image="https://media.istockphoto.com/id/95616723/photo/lamb-kebabs.jpg?b=1&s=170667a&w=0&k=20&c=os2dvF5CaY2snxasFwgfl3rUVaU4YDVYflQZUZr3S8A=", Name="Beef Souvlaki", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 109, Image="https://images.unsplash.com/photo-1603360946369-dc9bb6258143?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8TGFtYiUyMFNvdXZsYWtpJTIwZm9vZHxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=700&q=60", Name="Lamb Souvlaki", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 110, Image="https://media.istockphoto.com/id/1136417746/photo/moussaka-with-minced-meat.jpg?b=1&s=170667a&w=0&k=20&c=lPPJf9PKO2NodN-3BHuH6XqY9JavjCLrF5OQhhHLr3k=", Name="Moussaka", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 111, Image="https://media.istockphoto.com/id/1263363580/photo/traditional-dish-dolma.jpg?b=1&s=170667a&w=0&k=20&c=qOGEnNJzD20F0mFJam2uF0fuOlkWCFgtTtpb5cgyGxM=", Name="Dolmades", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 112, Image="https://media.istockphoto.com/id/1300215085/photo/spanakopita-with-tzatziki-sauce.jpg?b=1&s=170667a&w=0&k=20&c=o6WfKmaypUpZDwOH3d0wrZxEefWU4D6gsvZasGYnrqg=", Name="Spanakopita", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 113, Image="https://media.istockphoto.com/id/1438852765/photo/greek-cheese-pie.jpg?b=1&s=170667a&w=0&k=20&c=OYpNON4tNzxDubPIlfaRw912WD9kLLIKKraYfg-D8Q8=", Name="Tiropita", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 114, Image="https://media.istockphoto.com/id/1215293806/photo/tzatziki-dip-and-pita-bread-chips.jpg?b=1&s=170667a&w=0&k=20&c=CR_hL0gpM7tW5dD-TUz-Lk8yuydFKbDjfVXlkE9aXps=", Name="Tzatziki", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 115, Image="https://media.istockphoto.com/id/1393968807/photo/fasolada-greek-soup-with-white-beans-and-vegetables.jpg?b=1&s=170667a&w=0&k=20&c=J2ZNYJ_my7izNierzFXcmSVoHEzOnwKUCXu04wRrRo4=", Name="Fasolada", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 116, Image="https://media.istockphoto.com/id/1406693924/photo/traditional-turkish-lamb-intestine-kokorec-appetizer-meze-fastfood-dish-serving-at-istanbul.jpg?b=1&s=170667a&w=0&k=20&c=iSv3pVYIIAiC5rZISo_0zkgSXIqeKMeR4Ebnw0iKLMY=", Name="Kokoretsi", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 117, Image="https://media.istockphoto.com/id/183422455/photo/perfect-baklava-with-pistachio-arranged-on-a-white-plate.jpg?b=1&s=170667a&w=0&k=20&c=GXaXdgpuNeV7k0NVUf2MZ1VGSQ3aCMaSIWuNf9nPSVo=", Name="Baklava", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 118, Image="https://media.istockphoto.com/id/479378706/photo/lamb-kleftiko-greek-food-greece.jpg?b=1&s=170667a&w=0&k=20&c=gw7bobCRU56-5_-eqLuw4et1RbUb57S3IkLqSGILbFY=", Name="Kleftiko", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 119, Image="https://media.istockphoto.com/id/1427587599/photo/green-shrimp-saganaki.jpg?b=1&s=170667a&w=0&k=20&c=NnOcsh78HnB0onlTjURlRjRMGSzSXAM10XBR0gIbfRE=", Name="Saganaki", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 120, Image="https://media.istockphoto.com/id/1297617686/photo/homemade-lokma.jpg?b=1&s=170667a&w=0&k=20&c=jsMdPwhp4JvQPgvsKM4dPcIUFULuqkRYHjBVfYnBkIg=", Name="Loukoumaeds", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 121, Image="https://media.istockphoto.com/id/1418478807/photo/custard-of-galaktoboureko-or-bougatsa-greek-traditional-dessert-baked-in-a-pan-with-syrup-its.jpg?b=1&s=170667a&w=0&k=20&c=Z1QMSSyoYRKixL6nTRzXRr5vMj8VXOHkrrq8uIXsBCI=", Name="Galaktoboureko", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 122, Image="https://media.istockphoto.com/id/615488680/photo/cornish-pasty.jpg?b=1&s=170667a&w=0&k=20&c=bQnJic1NsniyXeYygXHnJCQyEmYaIRcxCiRxc8PFiXA=", Name="Pastitso", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 123, Image="https://media.istockphoto.com/id/1398490793/photo/simits-turkish-bakery-products-sesame-bagels-simit-cooked-in-bulk.jpg?b=1&s=170667a&w=0&k=20&c=ImX9Yv_tbCsR2rAyoIyQvIhUTVKjF8lYQfdMx7gfcS4=", Name="Koulori", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 124, Image="https://www.mygreekdish.com/wp-content/uploads/2013/05/Gemista-recipe-Greek-Stuffed-Tomatoes-and-peppers-with-rice-600x400.jpg", Name="Gemitsa", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 125, Image="https://media.istockphoto.com/id/1187669680/photo/baked-zucchini-potatoes-eggplant-and-onions-in-tomato-sauce-close-up-in-a-pan-vertical-top.jpg?s=612x612&w=0&k=20&c=smZNOEEP18kLSkpgs2YuPfsBPNXssP9O_nbQphg4PCU=", Name="Briam", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 126, Image="https://media.istockphoto.com/id/1273925282/photo/greek-chickpea-soup-with-lemon-oregano.jpg?s=612x612&w=0&k=20&c=chgu2Blhh4tkDpv6fWtjSfp7CsJV_KtZfK314CQIqy4=", Name="Revithosoupa", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 127, Image="https://media.istockphoto.com/id/1219713707/photo/taramasalata-dip-with-pita-bread-and-olives.jpg?s=1024x1024&w=is&k=20&c=L0lpkQtPfyM3xHMTApX0SQCycB7ZUxRkWU9Om6RbUkE=", Name="Taramosalata", Price=12.34M  , Available = true  },
            //    new Item {ItemId= 128, Image="https://unsplash.com/photos/IGfIGP5ONV0", Name="Salad", Price=12.34M  , Available = true  },

            //};

            //var menuItems = new MenuItem[]
            //{
            //    // form MID RID
            //    //Choc Cho full menu
            //    new MenuItem{MenuId= 0 , ItemId= 0 },
            //    new MenuItem{MenuId= 0 , ItemId= 1 },
            //    new MenuItem{MenuId= 0 , ItemId= 2 },
            //    new MenuItem{MenuId= 0 , ItemId= 3 },
            //    new MenuItem{MenuId= 0 , ItemId= 4 },
            //    new MenuItem{MenuId= 0 , ItemId= 5 },
            //    new MenuItem{MenuId= 0 , ItemId= 6 },
            //    new MenuItem{MenuId= 0 , ItemId= 7 },
            //    new MenuItem{MenuId= 0 , ItemId= 8 },
            //    new MenuItem{MenuId= 0 , ItemId= 9 },
            //    new MenuItem{MenuId= 0 , ItemId= 10 },
            //    new MenuItem{MenuId= 0 , ItemId= 11 },
            //    new MenuItem{MenuId= 0 , ItemId= 12 },
            //    new MenuItem{MenuId= 0 , ItemId= 13 },
            //    new MenuItem{MenuId= 0 , ItemId= 14 },
            //    new MenuItem{MenuId= 0 , ItemId= 15 },
            //    new MenuItem{MenuId= 0 , ItemId= 16 },
            //    new MenuItem{MenuId= 0 , ItemId= 17 },
            //    new MenuItem{MenuId= 0 , ItemId= 18 },
            //    new MenuItem{MenuId= 0 , ItemId= 19 },
            //    new MenuItem{MenuId= 0 , ItemId= 20 },
            //    new MenuItem{MenuId= 0 , ItemId= 21 },
            //    new MenuItem{MenuId= 0 , ItemId= 22 },
            //    new MenuItem{MenuId= 0 , ItemId= 23 },
            //    new MenuItem{MenuId= 0 , ItemId= 24 },

            //    // Uchi Sushi Menu
            //    new MenuItem{MenuId= 1 , ItemId= 25 },
            //    new MenuItem{MenuId= 1 , ItemId= 26 },
            //    new MenuItem{MenuId= 1 , ItemId= 27 },
            //    new MenuItem{MenuId= 1 , ItemId= 28 },
            //    new MenuItem{MenuId= 1 , ItemId= 29 },
            //    new MenuItem{MenuId= 1 , ItemId= 30 },
            //    new MenuItem{MenuId= 1 , ItemId= 31 },
            //    new MenuItem{MenuId= 1 , ItemId= 32 },
            //    new MenuItem{MenuId= 1 , ItemId= 33 },
            //    new MenuItem{MenuId= 1 , ItemId= 34 },
            //    new MenuItem{MenuId= 1 , ItemId= 35 },
            //    new MenuItem{MenuId= 1 , ItemId=36},

            //    // Uchi Entree Menu 
            //    new MenuItem{MenuId= 2 , ItemId= 37 },
            //    new MenuItem{MenuId= 2 , ItemId= 38 },
            //    new MenuItem{MenuId= 2 , ItemId= 39 },
            //    new MenuItem{MenuId= 2 , ItemId= 40 },
            //    new MenuItem{MenuId= 2 , ItemId= 41 },
            //    new MenuItem{MenuId= 2 , ItemId= 42 },
            //    new MenuItem{MenuId= 2 , ItemId= 43 },
            //    new MenuItem{MenuId= 2 , ItemId= 44 },
            //    new MenuItem{MenuId= 2 , ItemId= 45 },
            //    new MenuItem{MenuId= 2 , ItemId= 46 },
            //    new MenuItem{MenuId= 2 , ItemId= 47 },
            //    new MenuItem{MenuId= 2 , ItemId= 48 },

            //    // Bananza Breakfast
            //    //new MenuItem{MenuId= 0 , ItemId= 49 },
            //    //new MenuItem{MenuId= 0 , ItemId= 50 },
            //    //new MenuItem{MenuId= 0 , ItemId= 51 },
            //    //new MenuItem{MenuId= 0 , ItemId= 52 },
            //    //new MenuItem{MenuId= 0 , ItemId= 53 },
            //    //new MenuItem{MenuId= 0 , ItemId= 54 },
            //    //new MenuItem{MenuId= 0 , ItemId= 55 },
            //    //new MenuItem{MenuId= 0 , ItemId= 56 },

            //    //// Bananza Lunch 
            //    //new MenuItem{MenuId= 1 , ItemId= 57 },
            //    //new MenuItem{MenuId= 1 , ItemId= 58 },
            //    //new MenuItem{MenuId= 1 , ItemId= 59 },
            //    //new MenuItem{MenuId= 1 , ItemId= 60 },
            //    //new MenuItem{MenuId= 1 , ItemId= 61 },
            //    //new MenuItem{MenuId= 1 , ItemId= 62 },
            //    //new MenuItem{MenuId= 1 , ItemId= 63 },
            //    //new MenuItem{MenuId= 1 , ItemId= 64 },
            //    //new MenuItem{MenuId= 1 , ItemId= 65 },
            //    //new MenuItem{MenuId= 1 , ItemId= 66 },
            //    //new MenuItem{MenuId= 1 , ItemId= 67 },
            //    //new MenuItem{MenuId= 1 , ItemId= 68 },
            //    //new MenuItem{MenuId= 1 , ItemId= 69 },
            //    //new MenuItem{MenuId= 1 , ItemId= 70 },
            //    //new MenuItem{MenuId= 1 , ItemId= 71 },
            //    //new MenuItem{MenuId= 1 , ItemId= 72 },
            //    //// Bananza Dinner
            //    //new MenuItem{MenuId= 2 , ItemId= 65 },
            //    //new MenuItem{MenuId= 2 , ItemId= 66 },
            //    //new MenuItem{MenuId= 2 , ItemId= 67 },
            //    //new MenuItem{MenuId= 2 , ItemId= 68 },
            //    //new MenuItem{MenuId= 2 , ItemId= 69 },
            //    //new MenuItem{MenuId= 2 , ItemId= 70 },
            //    //new MenuItem{MenuId= 2 , ItemId= 71 },
            //    //new MenuItem{MenuId= 2 , ItemId= 72 },
            //    ////Pie Plaza Sweets
            //    //new MenuItem{MenuId= 0 , ItemId= 73 },
            //    //new MenuItem{MenuId= 0 , ItemId= 74 },
            //    //new MenuItem{MenuId= 0 , ItemId= 75 },
            //    //new MenuItem{MenuId= 0 , ItemId= 76 },
            //    //new MenuItem{MenuId= 0 , ItemId= 77 },
            //    //new MenuItem{MenuId= 0 , ItemId= 78 },

            //    ////Pie Plaza Savory
            //    //new MenuItem{MenuId= 1, ItemId= 79 },
            //    //new MenuItem{MenuId= 1, ItemId= 80 },
            //    //new MenuItem{MenuId= 1, ItemId= 81 },
            //    //new MenuItem{MenuId= 1, ItemId= 82 },
            //    //new MenuItem{MenuId= 1, ItemId= 83 },
            //    //new MenuItem{MenuId= 1, ItemId= 84 },
            //    //new MenuItem{MenuId= 1, ItemId= 85 },
            //    //new MenuItem{MenuId= 1, ItemId= 86 },
            //    //new MenuItem{MenuId= 1, ItemId= 87 },
            //    //new MenuItem{MenuId= 1, ItemId= 88 },
            //    //new MenuItem{MenuId= 1, ItemId= 89 },
            //    //new MenuItem{MenuId= 1, ItemId= 90 },

            //    ////Pie Plaza Specialty
            //    //new MenuItem{MenuId= 0 , ItemId= 91 },
            //    //new MenuItem{MenuId= 2, ItemId= 91 },
            //    //new MenuItem{MenuId= 2, ItemId= 92 },
            //    //new MenuItem{MenuId= 2, ItemId= 93 },
            //    //new MenuItem{MenuId= 2, ItemId= 94 },
            //    //new MenuItem{MenuId= 2, ItemId= 95 },
            //    //new MenuItem{MenuId= 2, ItemId= 96 },
            //    //new MenuItem{MenuId= 2, ItemId= 97 },
            //    //new MenuItem{MenuId= 2, ItemId= 98 },
            //    //new MenuItem{MenuId= 2, ItemId= 99 },
            //    //new MenuItem{MenuId= 2, ItemId= 100 },
            //    //new MenuItem{MenuId= 2, ItemId= 101 },
            //    //new MenuItem{MenuId= 2, ItemId= 102 },
            //    //new MenuItem{MenuId= 2, ItemId= 103 },
            //    //new MenuItem{MenuId= 2, ItemId= 104 },

            //    ////Gyro Pouch Main 
            //    //new MenuItem{MenuId=0, ItemId= 105},
            //    //new MenuItem{MenuId=0, ItemId= 106},
            //    //new MenuItem{MenuId=0, ItemId= 107},
            //    //new MenuItem{MenuId=0, ItemId= 108},
            //    //new MenuItem{MenuId=0, ItemId= 109},
            //    //new MenuItem{MenuId=0, ItemId= 110},
            //    //new MenuItem{MenuId=0, ItemId= 116},
            //    //new MenuItem{MenuId=0, ItemId= 118},
            //    //new MenuItem{MenuId=0, ItemId= 122},

            //    ////Gyro Pouch side 
            //    //new MenuItem{MenuId=1, ItemId= 111},
            //    //new MenuItem{MenuId=1, ItemId= 112},
            //    //new MenuItem{MenuId=1, ItemId= 113},
            //    //new MenuItem{MenuId=1, ItemId= 114},
            //    //new MenuItem{MenuId=1, ItemId= 115},
            //    //new MenuItem{MenuId=1, ItemId= 119},
            //    //new MenuItem{MenuId=1, ItemId= 126},
            //    //new MenuItem{MenuId=1, ItemId= 127},
            //    //new MenuItem{MenuId=1, ItemId= 128},

            //    ////Gyro Pouch Sweets
            //    //new MenuItem{MenuId=2, ItemId= 117},
            //    //new MenuItem{MenuId=1, ItemId= 120},
            //    //new MenuItem{MenuId=1, ItemId= 121},
            //    //new MenuItem{MenuId=1, ItemId= 123},


            //};

        }


    }
}