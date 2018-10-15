using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinaryRep
{
    class LinkedQueue<T> : QueueInterface<T>
    {
        private Node<T> front;
        private Node<T> rear;

        public LinkedQueue()
        {
            front = null;
            rear = null;
        }

        public T push(T element)
        {
            if(element == null)
            {
                throw new NullReferenceException();
            }

            if (isEmpty())
            {
                Node<T> tmp = new Node<T>(element, null);
                front = tmp;
                rear = tmp;

            }
            else
            {
                // General case
                Node<T> tmp = new Node<T>(element, null);
                rear.next = tmp;
                rear = tmp;
            }
            return element;
        }

        public T pop()
        {
            T tmp;
            if (isEmpty())
            {
                throw new QueueUnderflowException("The queue was empty when pop was invoked");

            }
            else if(front == rear)
            {
                // one item in queue
                tmp = front.data;
                front = null;
                rear = null;
            }
            else
            {
                // General case
                tmp = front.data;
                front = front.next;
            }
            return tmp;
        }

        public Boolean isEmpty()
        {
            return ((front == null) && (rear == null));
        }
    }
}