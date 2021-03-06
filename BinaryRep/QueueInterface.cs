﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinaryRep
{
    /**
    * A FIFO queue interface.  This ADT is suitable for a singly
    * linked queue.
    */
    interface QueueInterface<T>
    {
        /**
        * Add an element to the rear of the queue
        * 
        * @return the element that was enqueued
        */
        T push(T element);
        /**
        * Remove and return the front element.
        * 
        * @throws Thrown if the queue is empty
        */
        T pop();
        /**
        * Test if the queue is empty
        * 
        * @return true if the queue is empty; otherwise false
        */
        Boolean isEmpty();
    }
}