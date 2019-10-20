﻿namespace DataStructures.Stack
{
    class Node<T>
    {
        public T Value { get; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}
