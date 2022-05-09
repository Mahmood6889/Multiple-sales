using System.Collections.Generic;
public class process
{
    public class products
    {
        public string Name { get; set; }
        public int price { get; set; }
        public int count { get; set; }
        public int status { get; set; }


    }
    List<products> list = new List<products>();

    public void menu()
    {
        System.Console.WriteLine("please choose:");
        System.Console.WriteLine("manger>>>>>>>1");
        System.Console.WriteLine("user>>>>>>>>>2");

        choose();
    }
    public void choose()
    {
        int c;
        c = Convert.ToInt32(Console.ReadLine());
        switch (c)
        {
            case 1:
                manage();

                break;
            case 2:
                user();

                break;
        }

    }
    public void user()
    {  
        products p = new products();
        System.Console.WriteLine("please insert product name:");
        p.Name = Console.ReadLine();
        System.Console.WriteLine("please insert product price:");
        p.price = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("please insert product count:");
        p.count = Convert.ToInt32(Console.ReadLine());
        list.Add(p);
        
        manage();
    }

    public void manage()
    {
        int pass;
        do
        {
            System.Console.WriteLine("plase enter pass:");
            pass = Convert.ToInt32(Console.ReadLine());

        } while (pass != 1234);

        show();

    }

    public void show()
    {
        foreach (var item in list)
        {
            System.Console.WriteLine("name of product:" + item.Name +
             " " + "price:" + item.price + " " + "count:" + item.count);
        }
        requst();

    }

    public void requst()
    {
        System.Console.WriteLine("please enter one of them:");
        System.Console.WriteLine("accept=>1*******reject=>2");
        int b;
        b = Convert.ToInt32(Console.ReadLine());
        switch (b)
        {
            case 1:
                accept();
                break;
            case 2:
                reject();
                break;
        }

    }
    public void accept()
    {
        foreach (var item in list)
        {
            item.status = 1;
        }
        final();
    }

    public void reject()
    {
        foreach (var item in list)
        {
            item.status = -1;
        }
       final();
    }
     
     public void final()
     {
        foreach (var item in list)
        {
            if (item.status==1)
            {
               System.Console.WriteLine("name of product:" + item.Name +
             " " + "price:" + item.price + " " + "count:" + item.count);
            }
            if (item.status==-1)
            {
                System.Console.WriteLine("products not registered");
            }
        }

     }
     
}