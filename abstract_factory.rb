class AbtractFactory
  def createProductA
    raise NotImplementedException("Subclass responsability")
  end

  def createProductB
    raise NotImplementedException("Subclass responsability")
  end
end

class AbtractFactoryX < AbtractFactory
  def createProductA
    ProductA.new
  end
  def createProductB
    ProductB.new
  end
end

class AbtractFactoryY < AbtractFactory
  def createProductA
    ProductA.new
  end
  def createProductB
    ProductB.new
  end
end


f = AbtractFactoryX.new
a = f.createProductA
b = f.createProductB
