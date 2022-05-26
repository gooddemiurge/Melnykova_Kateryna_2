using System;
using System.Collections.Generic;

public class Bird
{
	public Bird(string name)
	{
		Name = name;
	}

	public string Name { get; set; }

	public void Fly()
	{
		Console.WriteLine("Цей птах вмiє лiтати");
	}

	public virtual void Sing()
	{
		Console.WriteLine("Цей птах вмiє спiвати");
	}

	public void Eggs()
	{
		Console.WriteLine("Цей птах несе яйця");
	}

	public virtual void Child()
	{
		Console.WriteLine("Цей птах висиджує пташенят");
	}

	public override int GetHashCode()
	{
		Console.WriteLine("Hash Code: ");
		return (Name + this.GetType()).GetHashCode();
	}

	public override string ToString()
	{
		Console.WriteLine("Iм'я та тип об'єкту:");
		return $"{Name}, {this.GetType()}";
	}

	public override bool Equals(object obj)
	{
		Console.WriteLine("\nЧи однаковi об'єкти?");
		if (obj is Bird bird) return Name == bird.Name && obj.GetType() == this.GetType();
		return false;
	}
}


public class Cuckoo : Bird
{
	public Cuckoo(string name) : base(name)
	{
	}

	public override void Child()
	{
		Console.WriteLine("Цей птах не висиджує пташенят");
	}
}

public class Chicken : Cuckoo
{
	public Chicken(string name) : base(name)
	{
	}

	public override void Sing()
	{
		Console.WriteLine("Цей птах не вмiє спiвати");
	}

}

public class Sitter : Chicken
{
	public Sitter(string name) : base(name)
	{
	}

	public override void Child()
	{
		Console.WriteLine("Цей птах висиджує пташенят");
	}
}

public class Birds
{
	public List<Bird> List_of_Birds;
	public Birds(List<Bird> birds) 
	{
		List_of_Birds = birds;
	}

	public void Print_birds() 
	{
		for (int i = 0; i < List_of_Birds.Count; i++)
		{
			Console.WriteLine(List_of_Birds[i].ToString());
			List_of_Birds[i].Fly();
			List_of_Birds[i].Sing();
			List_of_Birds[i].Eggs();
			List_of_Birds[i].Child();
		}
	}
}
