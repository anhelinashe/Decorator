using System;
interface ICharacter
{
    void Attack();
}
class BasicCharacter : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Character attack");
    }
}

class ArmoredCharacter : ICharacter
{
    private ICharacter _character;
    public ArmoredCharacter(ICharacter character)
    {
        _character = character;
    }

    public void Attack()
    {
        Console.WriteLine("Attack in rainforced armor");
        _character.Attack();
    }
}

class WeaponCharacter : ICharacter
{
    private ICharacter _character;

    public WeaponCharacter(ICharacter character)
    {
        _character = character;
    }

    public void Attack()
    {
        Console.WriteLine("Attack with a powerfull weapon");
        _character.Attack();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICharacter character = new BasicCharacter();
        character = new ArmoredCharacter(character);
        character = new WeaponCharacter(character);

        character.Attack();
    }
}
