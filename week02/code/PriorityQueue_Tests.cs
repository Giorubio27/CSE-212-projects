using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: I want to test to see if the add works in my priority queue tests
    // Expected Result: "5", 5
    // Defect(s) Found: 1. they skip the last item in the priority queue, they arent picking up the highpriority index
    // I fixed this by taking out the Count - 1 and just leaving the Count so that it picks up the last number in the list. I also made the loop start at zero and go all the way

    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("5", 5);
        priorityQueue.Enqueue("2", 1);
        priorityQueue.Enqueue("8", 8);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("8", result);

    }

    [TestMethod]
    // Scenario: Having 2 max priorities and having the FIFO rule apply still
    // Expected Result: 8a, 8 
    // Defect(s) Found: I had to switch the >= into just a greater than so the the first duplicate entered would be the first out as well(FIFO)
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("5", 5);
        priorityQueue.Enqueue("2", 1);
        priorityQueue.Enqueue("8a", 8);
        priorityQueue.Enqueue("5", 5);
        priorityQueue.Enqueue("8b", 8);

        var firstRemoved = priorityQueue.Dequeue();

        Assert.AreEqual("8a", firstRemoved, "The first number removed was the first 8");


    }
    [TestMethod]
    // Scenario: I want to test to see if the dequeue works when the queue is empty
    // Expected Result: No one in queue response
    // Defect(s) Found: I was able to find the solution and there were no bugs in the original code.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown");

        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);

        }

    }
    // Add more test cases as needed below.
}