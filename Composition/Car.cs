namespace Composition;

public class Car
{
	public Engine engine;
	public Lamp lamp;

	public Car(Engine engine, Lamp lamp)
	{
		this.engine = engine;
		this.lamp = lamp;
	}

	public void Start()
	{
		engine.EngineRun();
		lamp.TurnOn();
	}
}
