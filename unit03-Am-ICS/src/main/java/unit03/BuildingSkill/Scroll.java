package unit03.BuildingSkill;

public class Scroll 
{
    public static void documentMagicCreature(MagicCreature magicCreature) 
    {
        System.out.println(magicCreature.getName()+", " + magicCreature.getPowerLevel());
        System.err.println(magicCreature.performMagic());
        System.err.println(magicCreature.Speak());
    }
    public static void main(String[] args) 
    {
        // MagicCreature firewing = new MagicCreature("firewing", 85);
        // documentMagicCreature(firewing);
        Dragon Draco = new Dragon("Draco", 95);
        Unicorn Luna = new Unicorn("Lunca", 80);
        documentMagicCreature(Draco);
        documentMagicCreature(Luna);
        // System.out.println(Draco.performMagic());
        // System.out.println(Luna.performMagic());
        // MagicCreature mc = new MagicCreature("Gnome", 1);
        // this is no error because there is no absract
        // System.out.println(mc.performMagic());
        Flamewing flame = new Flamewing("flame", 80);
        documentMagicCreature(flame);
        
    }
}
