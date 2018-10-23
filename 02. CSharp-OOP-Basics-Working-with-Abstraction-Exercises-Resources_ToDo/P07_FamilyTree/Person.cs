using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private string birthday;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {

    }
    public Person(string name, string birthday)
    {
        this.name = name;
        this.birthday = birthday;
        this.Children = new List<Person>();
        this.Parents = new List<Person>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }

    public List<Person> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Person> Children
    {
        get { return children; }
        set { children = value; }
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetBirthDay()
    {
        return this.birthday;
    }

    public void AddParent(Person person)
    {
        this.Parents.Add(person);
    }
    public void AddChild(Person person)
    {
        this.Children.Add(person);
    }
    public void Print()
    {
        Console.WriteLine(this);
        Console.WriteLine("Parents:");
        Parents.ForEach(Console.WriteLine);
        Console.WriteLine("Children:");
        Children.ForEach(Console.WriteLine);
    }
    public override string ToString()
    {
        return $"{Name} {Birthday}";
    }
}
