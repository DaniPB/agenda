public interface IAbstractFactory{
  IProductA createProductA(); 
  IProductB createProductB(); 
}

public interface IProductA{
}

public class ProductAX : IProductA {
}

public class ProductAY : IProductA {
}

public interface IProductB{
}

public class ProductBX : IProductB{
}

public class ProductBY: IProductB{
}

public class ConcreteFactoryX : IAbstractFactory{
  IProductA createProductA(){
    return new ProductAX();
  } 

  IProductB createProductB(){
    return new ProductBX();
  }
}

public class ConcreteFactoryY : IAbstractFactory{
  IProductA createProductA(){
    return new ProductAY();
  }
  IProductB createProductB(){
    return new ProductBY();
  } 
}

//client
IAbstractFactory f = new ConcreteFactoryY();
IProductA a = f.createProductA();
IProductB b = f.createProductB();
