namespace adavanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            /*
             
            Generics allow you to write classes,
            interfaces and methods with type parameters.
            The actual type is specified when the code is used,
            not when it is written.   C#
             
             Type-safe: Errors are caught at compile time.  
            Reusable: One implementation works for many types.   
            Better performance: No boxing/unboxing for value types.  
            Cleaner code: Avoids code duplication.   
             
             
             */

            #endregion


            #region Q2 Write a generic class Container<T> with Add and Get methods.

            /*
             check the class
             */
            #endregion Q3 What are multiple type parameters? Write Pair<TKey, TValue>.

            /*
             
             multiple type give you the flexability to write more than genaric type 
            in the same class
             
            check pair class
             */
            #region Q4: What is a generic method? Write Swap<T> method.

            /*
             generic method is a method can get any kind of data types
             check  swap method in container class 
             */
            #endregion


            #region Q5: Write a generic method FindMax<T> that finds maximum value
            /*
             
             check container class
             */

            #endregion


            #region Q6: What is a generic interface? Write IRepository<T>.


            #endregion


            #region  Q7: What is the 'struct' constraint? Write an example.
            /*
             generic type parameter to value types only
             
             ex: public class Box<T> where T : struct
{
             */

            #endregion


            #region Q8: What is the 'class' constraint? Write an example.
            /*
              generic type parameter to refrance types only
             
             ex: public class Box<T> where T : class
{ 

             */

            #endregion

            #region Q9 What is the 'new()' constraint? Write an example.
            /*

             equires that the type used for T have a public parameterless constructor
                         ex: public class Box<T> where T : new()

             */

            #endregion

            #region Q10: What is the interface constraint? Write an example.
            /*
             Constraints allow you to specify which types can be used as type
               arguments for a generic type or method.

            public class Factory<T> where T : new()
{           or
            public class Factory<T> where T : class
{
             
             */

            #endregion


            #region Q11: What is the base class constraint? Write an example.
            /*
             

            The base class constraint restricts a generic type parameter to 
            specific class (or one of its subclasses)

           ex: public class AnimalShelter<T> where T : Animal{-----}

             
             */

            #endregion


            #region Q12: How do you apply multiple constraints? Write an example.

            /*
             You apply multiple constraints by listing them after where T :, separated by commas.
             
            C# does enforce an order when certain constraint types are combined
            ex: public class Repository<T> where T : class, IComparable, new()
             */
            #endregion


            #region Q13: What does the 'default' keyword do in generics?
            /*
             a keyword give the T the default value  
             
             */

            #endregion


            #region Q14: Write a SafeList<T> that returns default when the index is invalid.
            /*
             check Safelist class
             */

            #endregion


            #region Q15: What is covariance? Explain the 'out' keyword.

            /*
             * Covariance allows you to use a more derived type (a more specific child class)
             * where a less derived type (a more general base class) is expected.
             
             Use the out keyword to specify that the type parameter
            is used only as output (return type).   
             */
            #endregion


            #region Q16
            /*
             * 
             * Contravariance allows you to use a less derived type (a more general base class) where 
             * a more derived type (a more specific child class) is expected. 
             * Use the in keyword to specify that the type parameter is used only as input (method parameter).
             */

            #endregion

            #region Q17
            /*
             * **Covariance** allows you to use a more derived type (a more specific child class) 
             * where a less derived type (a more general base class) is expected. 
             * Use the **out** keyword to specify that the type parameter is used only as output (return type).


*        **Contravariance** allows you to use a less derived type (a more general base class) 
*        where a more derived type (a more specific child class) is expected. 
*        Use the **in** keyword to specify that the type parameter is used only as input (method parameter).
             */

            #endregion

        }
    }
}
