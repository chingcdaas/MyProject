package unit03;

public class Cat extends SocialAnimal
{
    public Cat(String name)
    {
        super(name);
    }
    @Override
    public String makeSound() 
    {
        return "Meow meow";
    }

    @Override
    public void talkTo(SocialAnimal animal) 
    {
        System.out.println(this.getName() + " purrs meow to " + animal.getName() + " with a big smile.");
    }

}
