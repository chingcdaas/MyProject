package unit03;

public class Tiger implements  Animal
{
    private int weight;
    public Tiger(int weight)
    {
        this.weight = weight;
    }
    public int getWeight()
    {
        return weight;
    }
    @Override
    public String makeSound() {
        return "grr";
    }
    public String toString()
    {
        return weight + " " + "lbs" + " " + "tiger";
    }

}
