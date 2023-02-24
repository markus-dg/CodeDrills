using CodeDrills.Ex6;

namespace CodeDrills.Tests.Ex6;

public class ArrayExerciseTest
{
    private ArrayExercise exercise = null!;

    [SetUp]
    public void Setup()
    {
        exercise = new ArrayExercise();
    }


    [Test]
    public void GetThirdElement_Test1()
    {
        int[] xs = new int[] { 1, 2, 3, 4, 5 };

        var result = exercise.GetThirdElement(xs);

        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void GetThirdElement_Test2()
    {
        int[] xs = new int[] { 7, 3, 4, 7 };

        var result = exercise.GetThirdElement(xs);

        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void GetThirdElement_Test3()
    {
        int[] xs = new int[] { 100, 1000, 10000, 100000 };

        var result = exercise.GetThirdElement(xs);

        Assert.That(result, Is.EqualTo(10000));
    }

    [Test]
    public void GetIthElement_Test1()
    {
        int[] xs = new int[] { 1, 2, 3, 4, 5 };

        var result0 = exercise.GetIthElement(xs, 0);
        Assert.That(result0, Is.EqualTo(1));

        var result1 = exercise.GetIthElement(xs, 1);
        Assert.That(result1, Is.EqualTo(2));

        var result4 = exercise.GetIthElement(xs, 4);
        Assert.That(result4, Is.EqualTo(5));
    }

    [Test]
    public void GetIthElement_Test2()
    {
        int[] xs = new int[] { 2, 3, 4, 7, 5, 6, 77 };

        var result0 = exercise.GetIthElement(xs, 0);
        Assert.That(result0, Is.EqualTo(2));

        var result3 = exercise.GetIthElement(xs, 3);
        Assert.That(result3, Is.EqualTo(7));

        var result6 = exercise.GetIthElement(xs, 6);
        Assert.That(result6, Is.EqualTo(77));
    }


    [Test]
    public void SumOfAllElements_Test1()
    {
        int[] xs = new int[] { 7 };

        var result = exercise.SumOfAllElements(xs);
        Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void SumOfAllElements_Test2()
    {
        int[] xs = new int[] { 7, 3, 4, 7, 5, 6, 77, 109, 2, 7, 1 };

        var result = exercise.SumOfAllElements(xs);
        Assert.That(result, Is.EqualTo(228));
    }

    [Test]
    public void SumOfAllElements_Test3()
    {
        int[] xs = new int[] { 74, 233, 44, 72, 59, 66, 7 };

        var result = exercise.SumOfAllElements(xs);
        Assert.That(result, Is.EqualTo(555));
    }

    [Test]
    public void SetSecondElementTo5_Test1()
    {
        int[] xs = new int[] { 74, 33 };

        var result = exercise.SetSecondElementTo5(xs);
        Assert.That(result, Is.EqualTo(new[] { 74, 5 }));
    }

    [Test]
    public void SetSecondElementTo5_Test2()
    {
        int[] xs = new int[] { 74, 233, 44, 72, 59, 66, 7 };

        var result = exercise.SetSecondElementTo5(xs);
        Assert.That(result, Is.EqualTo(new[] { 74, 5, 44, 72, 59, 66, 7 }));
    }

    [Test]
    public void SetSecondElementTo5_Test3()
    {
        int[] xs = new int[] { 0, 1, 0, 1, 0, 1, 0, 1, 0 };

        var result = exercise.SetSecondElementTo5(xs);
        Assert.That(result, Is.EqualTo(new[] { 0, 5, 0, 1, 0, 1, 0, 1, 0 }));
    }

    [Test]
    public void SetIthElementTo3_Test1()
    {
        int[] xs = new int[] { 74 };

        var result = exercise.SetIthElementTo3(xs, 0);
        Assert.That(result, Is.EqualTo(new[] { 3 }));
    }

    [Test]
    public void SetIthElementTo3_Test2()
    {
        int[] xs = new int[] { 74, 233, 44, 72, 59, 66, 7 };

        var result = exercise.SetIthElementTo3(xs, 2);
        Assert.That(result, Is.EqualTo(new[] { 74, 233, 3, 72, 59, 66, 7 }));
    }

    [Test]
    public void SetIthElementTo3_Test3()
    {
        int[] xs = new int[] { 0, 1, 0, 1, 0, 1, 0, 1, 0 };

        var result = exercise.SetIthElementTo3(xs, 8);
        Assert.That(result, Is.EqualTo(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 3 }));
    }

    [Test]
    public void SetIthElementToValue_Test1()
    {
        int[] xs = new int[] { 74 };

        var result = exercise.SetIthElementToValue(xs, 0, 99);
        Assert.That(result, Is.EqualTo(new[] { 99 }));
    }

    [Test]
    public void SetIthElementToValue_Test2()
    {
        int[] xs = new int[] { 74, 233, 44, 72, 59, 66, 7 };

        var result = exercise.SetIthElementToValue(xs, 2, 77);
        Assert.That(result, Is.EqualTo(new[] { 74, 233, 77, 72, 59, 66, 7 }));
    }

    [Test]
    public void SetIthElementToValue_Test3()
    {
        int[] xs = new int[] { 0, 1, 0, 1, 0, 1, 0, 1, 0 };

        var result = exercise.SetIthElementToValue(xs, 8, 22);
        Assert.That(result, Is.EqualTo(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 22 }));
    }

    [Test]
    public void SetAllElementsTo7_Test1()
    {
        int[] xs = new int[] { 74 };

        var result = exercise.SetAllElementsTo7(xs);
        Assert.That(result, Is.EqualTo(new[] { 7 }));
    }

    [Test]
    public void SetAllElementsTo7_Test2()
    {
        int[] xs = new int[] { 74, 233, 44, 72, 59, 66, 7 };

        var result = exercise.SetAllElementsTo7(xs);
        Assert.That(result, Is.EqualTo(new[] { 7, 7, 7, 7, 7, 7, 7 }));
    }

    [Test]
    public void SetAllElementsTo7_Test3()
    {
        int[] xs = new int[] { 0, 1, 0, 1, 0, 1, 0, 1, 0 };

        var result = exercise.SetAllElementsTo7(xs);
        Assert.That(result, Is.EqualTo(new[] { 7, 7, 7, 7, 7, 7, 7, 7, 7 }));
    }

    [Test]
    public void FindSmallestElement_Test1()
    {
        int[] xs = new int[] { 74 };

        var result = exercise.FindSmallestElement(xs);
        Assert.That(result, Is.EqualTo(74));
    }

    [Test]
    public void FindSmallestElement_Test2()
    {
        int[] xs = new int[] { 74, 233, 44, 72, 59, 66, -7 };

        var result = exercise.FindSmallestElement(xs);
        Assert.That(result, Is.EqualTo(-7));
    }

    [Test]
    public void FindSmallestElement_Test3()
    {
        int[] xs = new int[] { 0, -1, 0, 1, 0, -1, 0, 1, 0 };

        var result = exercise.FindSmallestElement(xs);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void FindSmallestElement_Test4()
    {
        int[] xs = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

        var result = exercise.FindSmallestElement(xs);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void RemoveDuplicates_Test1()
    {
        int[] xs = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

        var result = exercise.RemoveDuplicates(xs);
        // we don't care about the order
        Assert.That(result, Is.EqualTo(new int?[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }));
    }
    [Test]
    public void RemoveDuplicates_Test2()
    {
        int[] xs = new int[] { 0, 0, 2, 3, 2, 5, 0, 7, 2 };

        var result = exercise.RemoveDuplicates(xs);
        // we don't care about the order
        Assert.That(result, Is.EquivalentTo(new int?[] { 0, 2, 3, 5, 7, null, null, null, null }));
    }
    
    [Test]
    public void RemoveDuplicates_Test3()
    {
        int[] xs = new int[] { 0, 0, 0, 0, 0 };

        var result = exercise.RemoveDuplicates(xs);
        // we don't care about the order
        Assert.That(result, Is.EquivalentTo(new int?[] { 0, null, null, null, null }));
    } 
    
    [Test]
    public void RemoveDuplicates_Test4()
    {
        int[] xs = new int[] { 0, 1, 2, 3, 0 };

        var result = exercise.RemoveDuplicates(xs);
        // we don't care about the order
        Assert.That(result, Is.EquivalentTo(new int?[] { 0, 1, 2, 3, null }));
    }
}