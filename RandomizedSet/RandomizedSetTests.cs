using RandomizedSetApp;
using System;
using Xunit;

public class RandomizedSetTests//we can run it from view=>test explorer=>run
{
    [Fact]
    public void TestInsert()
    {
        RandomizedSet randomizedSet = new RandomizedSet();

        Assert.True(randomizedSet.Insert(10)); 
        Assert.True(randomizedSet.Insert(20)); 
        Assert.False(randomizedSet.Insert(10)); 
    }

    [Fact]
    public void TestRemove()
    {
        RandomizedSet randomizedSet = new RandomizedSet();
        randomizedSet.Insert(10);
        randomizedSet.Insert(20);
        randomizedSet.Insert(30);

        Assert.True(randomizedSet.Remove(20));
        Assert.False(randomizedSet.Remove(20)); 
        Assert.True(randomizedSet.Remove(10)); 
    }

    [Fact]
    public void TestGetRandom()
    {
        RandomizedSet randomizedSet = new RandomizedSet();
        randomizedSet.Insert(10);
        randomizedSet.Insert(20);
        randomizedSet.Insert(30);

        int randomValue = randomizedSet.GetRandom();
        Assert.Contains(randomValue, new int[] { 10, 20, 30 }); 
    }
}
