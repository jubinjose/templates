namespace SnackMachine.Logic.Model
{
    //Base Class for all Value Objects
    public abstract class ValueObject<T> where T : ValueObject<T>
    {

        public sealed override bool Equals(object obj)
        {
            var valueObject = obj as T;

            if (ReferenceEquals(valueObject, null)) return false;

            if (obj.GetType() != this.GetType()) return false; //Needed else base.equals(derived) can return true if properties match

            return EqualsCore(valueObject);
        }

        public abstract bool EqualsCore(T other);//Subclasses must implement the actual equality here

        public abstract override int GetHashCode();


        public static bool operator ==(ValueObject<T> lhs, ValueObject<T> rhs)
        {
            if (ReferenceEquals(lhs, null) && ReferenceEquals(rhs, null)) return true;

            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) return false;

            return lhs.Equals(rhs);
        }

        public static bool operator !=(ValueObject<T> lhs, ValueObject<T> rhs)
        {
            return !(lhs == rhs);
        }
    }

    
}
