using System;

abstract class Character
{
    private string characterType;
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override bool Vulnerable() => false;
    
    public override int DamagePoints(Character target) => target.Vulnerable() == true ? 10 : 6;
}

class Wizard : Character
{
    private bool isSpellPrepared = false;
    
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target){
        
        if (isSpellPrepared){
            return 12;
        }
        return 3;
    }
    public override bool Vulnerable() => !isSpellPrepared;
    

    public void PrepareSpell() => isSpellPrepared = true;
}
