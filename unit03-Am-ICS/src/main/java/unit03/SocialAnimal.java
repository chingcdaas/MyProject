package unit03;

public abstract class SocialAnimal implements Animal
{
    private String name;

    private SocialAnimal friend1;
    private  SocialAnimal friend2;
    public SocialAnimal(String name)
    {
        this.name = name;
    }
    public void setFriend1(SocialAnimal friend1)
    {
        this.friend1 = friend1;
    }
    public void setFriend2(SocialAnimal friend2)
    {
        this.friend2 = friend2;
    }
    public abstract void talkTo(SocialAnimal animal);

    public String getName()
    {
        return name;
    }
    public void spreadRumor() 
    {
        if (this.friend1 != null) 
        {
            this.talkTo(this.friend1);
            this.friend1.spreadRumor(); 
        }
        if (this.friend2 != null)
        {
            this.talkTo(this.friend2);
            this.friend2.spreadRumor();
        }
    }
    @Override
    public String toString() {
    return this.name + " [" + this.makeSound() + "]";
    }
}
