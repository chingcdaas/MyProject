package unit03;

import java.util.jar.Attributes;

public class Dog extends SocialAnimal
{

    public Dog(String name)
    {
        super(name);
    }

    @Override
    public String makeSound() 
    {
        return "woof woof";
    }
    
    @Override
    public void talkTo(SocialAnimal animal) 
    {
        System.out.println(this.getName() + " barks woof to " + animal.getName() + " waving its tail.");
    }
}
