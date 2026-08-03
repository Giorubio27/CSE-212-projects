using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: I want to test to see if the add works in my priority queue tests
    // Expected Result: "5", 5
    // Defect(s) Found: 1. they skip the last item in the priority queue, they arent picking up the highpriority index
    // 2. 

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
    // Expected Result: 8, 8 
    // Defect(s) Found: 
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
    // Expected Result: Noone in queue response
    // Defect(s) Found: 
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