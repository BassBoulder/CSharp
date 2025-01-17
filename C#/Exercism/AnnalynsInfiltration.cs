## V1
using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        return !knightIsAwake && !archerIsAwake && prisonerIsAwake || (!archerIsAwake && petDogIsPresent);
    }
}

## V2
using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) 
        => !knightIsAwake ? true : false;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        => (knightIsAwake || archerIsAwake || prisonerIsAwake) ? true : false;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        => (!archerIsAwake && prisonerIsAwake) ? true : false;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        return !knightIsAwake && !archerIsAwake && prisonerIsAwake || (!archerIsAwake && petDogIsPresent);
    }
}
