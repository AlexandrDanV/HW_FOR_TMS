using StackGeneric;
using System.Collections.Generic;

namespace Tests_forMyStack
{
    public class MyStack_Tests
    {
         MyStack<int> myStack_Int = new ();        
         MyStack<string> myStack_Str = new();

        [Fact]
        public void Count_2add_2return()
        {
            myStack_Int.Push(111);
            myStack_Int.Push(222);
            myStack_Str.Push("aaa");
            myStack_Str.Push("bbb");

            var actual_Int = myStack_Int.Count();
            var acttual_Str = myStack_Str.Count();

            Assert.Equal(2, actual_Int);
            Assert.Equal(2, acttual_Str);
        }

        [Fact]
        public void Pop_LastInFirstOut_Remove()
        {
            myStack_Int.Push(111);
            myStack_Int.Push(222);
            myStack_Str.Push("aaa");
            myStack_Str.Push("bbb");

            var actual_Int = myStack_Int.Pop();
            var actual_Str = myStack_Str.Pop();

            var count_Int = myStack_Int.Count();
            var count_Str = myStack_Str.Count();
            
            Assert.Equal(222, actual_Int);
            Assert.Equal("bbb", actual_Str);

            Assert.Equal(1, count_Int);
            Assert.Equal(1, count_Str);
        }
        [Fact]
        public void Peek_LastInFirstOut_WithoutRemove()
        {
            myStack_Int.Push(111);
            myStack_Int.Push(222);
            myStack_Str.Push("aaa");
            myStack_Str.Push("bbb");

            var actual_Int =  myStack_Int.Peek();
            var actual_Str = myStack_Str.Peek();

            var count_Int = myStack_Int.Count();
            var count_Str = myStack_Str.Count();

            Assert.Equal(222,actual_Int);
            Assert.Equal("bbb", actual_Str);

            Assert.Equal(2, count_Int);
            Assert.Equal(2, count_Str);
        }

        [Fact]
        public void Pop_stackIsEmpty_ExceptionReturn()
        {
            Assert.Throws<Exception>(() => myStack_Int.Pop());
        }
        [Fact]
        public void Peek_stackIsEmpty_ExceptionReturn()
        {            
            Assert.Throws<Exception>(() => myStack_Str.Peek());
        }
    }
}
