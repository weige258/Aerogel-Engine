namespace AerogelEngine.Engine;

public class Engine
{
    bool is_running = false;
    
    public Engine()
    {
        is_running = true;
    }

    public void Run()
    { 
        while (is_running)
        {
           
        }
    }

    ~Engine()
    {
        
    }
}