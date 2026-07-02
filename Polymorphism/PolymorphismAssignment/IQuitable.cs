using System;


namespace QuittableApp
{
    
    public interface IQuittable // defines a contract for quitting behavior that implementing classes must fulfill
    {
        
        void Quit(); // declares a method signature for quitting, which must be implemented by any class that implements this interface
    }
}
