namespace CodeDrills.Tests;

public class ListExerciseTest
{
    private ListExercise exercise;

    [SetUp]
    public void Setup()
    {
        exercise = new ListExercise();
    }

    [Test]
    public void Size_EmptyList()
    {
        var values = new List<int>();

        var size = exercise.Size(values);

        Assert.That(size, Is.Zero);
    }

    [Test]
    public void Size_ListWithFiveValues()
    {
        var values = new List<int> { 1, 2, 3, 4, 5 };

        var size = exercise.Size(values);

        Assert.That(size, Is.EqualTo(5));
    }

    [Test]
    public void FirstElement_ListWithFiveValues()
    {
        var values = new List<int> { 1, 2, 3, 4, 5 };

        var element = exercise.FirstElement(values);

        Assert.That(element, Is.EqualTo(1));
    }

    [Test]
    public void FirstElement_ListWithThreeValues()
    {
        var values = new List<int> { 3, 4, 5 };

        var element = exercise.FirstElement(values);

        Assert.That(element, Is.EqualTo(3));
    }

    [Test]
    public void LastElement_ListWithFiveValues()
    {
        var values = new List<int> { 1, 2, 3, 4, 5 };

        var element = exercise.LastElement(values);

        Assert.That(element, Is.EqualTo(5));
    }

    [Test]
    public void LastElement_ListWithThreeValues()
    {
        var values = new List<int> { 1, 2, 3 };

        var element = exercise.LastElement(values);

        Assert.That(element, Is.EqualTo(3));
    }

    [Test]
    public void Sum_EmptyList()
    {
        var values = new List<int>();

        var sum = exercise.Sum(values);

        Assert.That(sum, Is.EqualTo(0));
    }

    [Test]
    public void Sum_ListWithOneValue()
    {
        var values = new List<int> { 7 };

        var sum = exercise.Sum(values);

        Assert.That(sum, Is.EqualTo(7));
    }

    [Test]
    public void Sum_ListWithThreeValues()
    {
        var values = new List<int> { 1, 2, 3 };

        var sum = exercise.Sum(values);

        Assert.That(sum, Is.EqualTo(6));
    }

    [Test]
    public void Sum_ListWithFiveValues()
    {
        var values = new List<int> { 1, 2, 3, 4, 5 };

        var sum = exercise.Sum(values);

        Assert.That(sum, Is.EqualTo(15));
    }

    [Test]
    public void Min_ListWithOneValue()
    {
        var values = new List<int> { 42 };

        var min = exercise.Min(values);

        Assert.That(min, Is.EqualTo(42));
    }

    [Test]
    public void Min_ListWithTwoValue()
    {
        var values = new List<int> { 3, 15 };

        var min = exercise.Min(values);

        Assert.That(min, Is.EqualTo(15));
    }

    [Test]
    public void Min_ListWithFiveValue()
    {
        var values = new List<int> { 0, 17, -27, 18, 9 };

        var min = exercise.Min(values);

        Assert.That(min, Is.EqualTo(-27));
    }


    [Test]
    public void Reverse_ListWithOneValue()
    {
        var values = new List<int> { 5 };

        var reversedValues = exercise.Reverse(values);

        Assert.That(reversedValues, Is.EqualTo(new[] { 5 }));
    }

    [Test]
    public void Reverse_ListWithTwoValue()
    {
        var values = new List<int> { 1, 5 };

        var reversedValues = exercise.Reverse(values);

        Assert.That(reversedValues, Is.EqualTo(new[] { 5, 1 }));
    }

    [Test]
    public void Reverse_ListWithFiveValue()
    {
        var values = new List<int> { 1, 2, 3, 4, 5 };

        var reversedValues = exercise.Reverse(values);

        Assert.That(reversedValues, Is.EqualTo(new[] { 5, 4, 3, 2, 1 }));
    }
}