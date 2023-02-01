using GTANetworkAPI;

namespace ExampleResource
{

    public class Main : Script
    {

        [ServerEvent(Event.PlayerSpawn)]
        public void OnPlayerSpawn(Player ply) {
            NAPI.ClientEvent.TriggerClientEvent(ply, "client:showcefInfo", true);
            NAPI.ClientEvent.TriggerClientEvent(ply, "client:createInfo", "fa-solid fa-star-of-life", "Paramedic", "255, 255, 255", "120,120,120,0.3", "https://www.shutterstock.com/image-illustration/medical-health-red-cross-neon-260nw-1918247282.jpg");
            NAPI.ClientEvent.TriggerClientEvent(ply, "client:createInfo", "fa-solid fa-user", ply.Name, "255,255,255", "120,120,120,0.6", "https://img.freepik.com/free-vector/minimal-geometric-stripe-shape-background_1409-1014.jpg");
            NAPI.ClientEvent.TriggerClientEvent(ply, "client:createInfo", "fa-solid fa-money-bill-wave", "1234,50", "0,120,0", "120,120,120,0.9", "https://img.freepik.com/free-vector/green-curve-abstract-background_53876-99569.jpg?w=360");
        }

    }
}
