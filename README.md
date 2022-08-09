# 09_Protected_Access_Modifier
### Protected variable : keyword `protected`

Example: `protected string strName`

### This variable is accessible within the same class as well as all classes that inherited it *Derived Class*

```
class School{ 
    protected int intStudentCount = 0;
}
class Student:School{
  public Student (string strName){
  intStudentCount ++;   # *
  }
}
```

Student class can access `intStudentCount` to increas, because it is a protected variable where derived class can access easily.
