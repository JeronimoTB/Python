class Cat : DomesticAnimal
{
    //implement abstract method
    public override string sound()
    {
        return "Miau miau";
    }

    public void view_sound_cat(){
        Console.WriteLine(sound());
    }
}
