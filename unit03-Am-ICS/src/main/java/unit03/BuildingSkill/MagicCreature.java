package unit03.BuildingSkill;

public abstract class MagicCreature 
{
    private String name;
    private int powerLevel;
    public MagicCreature(String name, int powerLevel)
    {
        this.name = name;
        this.powerLevel = powerLevel;
    }
    public String getName()
    {
        return name;
    }
    public int getPowerLevel()
    {
        return powerLevel;
    }
    public abstract String performMagic();
    public abstract String Speak();
}
