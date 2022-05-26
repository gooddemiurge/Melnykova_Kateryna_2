using System;
using System.Collections.Generic;


public class Smartphone 
{
    public string Model { get; set; }
    public string Produser { get; set; }
    public double Size { get; set; }
    public int Price { get; set; }

    public Smartphone(string model, string produser, double size, int price) 
    {
        Model = model;
        Produser = produser;
        Size = size;
        Price = price;
    }


}

public class Shop 
{
    public List<Smartphone> Items;
    public Shop(List<Smartphone> items) 
    {
        Items = items;
    }

    public List<Smartphone> Sort_by_model(string m_to_f) 
    {
        List<Smartphone> answer = new List<Smartphone> { };
        for (int i = 0; i < Items.Count; i++) 
        {
            if (Items[i].Model == m_to_f) 
            {
                answer.Add(Items[i]);
            }
        }
        return answer;
    }

    public List<Smartphone> Sort_by_produser(string p_to_f)
    {
        List<Smartphone> answer = new List<Smartphone> { };
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].Produser == p_to_f)
            {
                answer.Add(Items[i]);
            }
        }
        return answer;
    }

    public List<Smartphone> Sort_by_size(double s_to_f)
    {
        List<Smartphone> answer = new List<Smartphone> { };
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].Size == s_to_f)
            {
                answer.Add(Items[i]);
            }
        }
        return answer;
    }

    public List<Smartphone> Sort_by_price(int minp_to_f = 0, int maxp_to_f = 100000000)
    {
        List<Smartphone> answer = new List<Smartphone> { };
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].Price >= minp_to_f && Items[i].Price <= maxp_to_f)
            {
                answer.Add(Items[i]);
            }
        }
        return answer;
    }

    public List<Smartphone> Find_by_parameters(string m_to_f = null, string p_to_f = null , double s_to_f = 0)
    {
        List<Smartphone> answer = new List<Smartphone> { };
        for (int i = 0; i < Items.Count; i++)
        {
            if ((Items[i].Model == m_to_f || m_to_f == null) && (Items[i].Produser == p_to_f || p_to_f == null) && (Items[i].Size == s_to_f || s_to_f == 0))
            {
                answer.Add(Items[i]);
            }
        }
        return answer;
    }

    public int Number_of_phones() 
    {
        return Items.Count;
    }

    public void Print_phones(string title = "") 
    {
        Console.WriteLine(title);
        for (int i = 0; i < Items.Count; i++) 
        {
            Console.WriteLine("Модель: " + Items[i].Model + " Виробник: " + Items[i].Produser + " Розмiр дисплею: " + Items[i].Size + " Цiна: " + Items[i].Price);
        }
    } 
}