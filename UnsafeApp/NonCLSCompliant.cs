using System;

[assembly: CLSCompliant(true)]
namespace NonCLS
{
    public class NonCLSCompliant
    {
        /// <summary>
        /// two or more public / protected / protected internal members defined with only case difference
        /// </summary>
        public int intA = 0;
        public int INTA = 2;

        /// <summary>
        /// two or more public / protected / protected internal members defined with only case difference
        /// </summary>
        public int x = 0;
        public void X()
        {
        }

        /// <summary>
        /// Declaring a member name preceding underscore (_) 
        /// with outside visible access specifiers (public, protected, protected internal)
        /// </summary>
        public void _test()
        {

        }

        /// <summary>
        /// Declaring unsigned type member with access public / protected / protected internal
        /// </summary>
        public uint a = 10;

        /// <summary>
        /// Declaring unsafe (pointer) type with access public / protected / protected internal
        /// </summary>
        protected internal unsafe int* c;

        /// <summary>
        /// A (public / protected / protected internal) method returning a non-CLS compliant type 
        /// or with parameter of non-CLS compliant type
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public uint testmethod(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void anothermethod(ushort x, int y)
        {
        }



    }

    /// <summary>
    /// An abstract member marked as non-CLS-Compliant in a CLS-Compliant class
    /// </summary>
    [CLSCompliant(true)]
    public abstract class B
    {
        [CLSCompliant(false)]
        protected internal abstract void test();
    }
}
