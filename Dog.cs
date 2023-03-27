class Dog : DomesticAnimal
{
    //implement abstract method
    public override string sound()
    {
        return "Guau guau";
    }

    public void view_sound_dog(){
        Console.WriteLine(sound());
    }
}
