using UnityEngine;

namespace osg {

    public class ScreenOverlay {
        private Player player;
        private TickCounter tickCounter;

        private TextGameObject numGoldCoinsText;
        private TextGameObject numWoodText;
        private TextGameObject numStoneText;
        private TextGameObject numApplesText;
        private TextGameObject numSaplingsText;
        private TextGameObject energyText;
        private TextGameObject mtpsText;

        public ScreenOverlay(Player player, TickCounter tickCounter) {
            this.player = player;
            this.tickCounter = tickCounter;
            initialize();
        }

        public void initialize() {
            int resourcesX = -Screen.width / 4;
            int resourcesY = -Screen.height / 4;
            numGoldCoinsText = new TextGameObject("Gold Coins: 0", 20, resourcesX, resourcesY);
            numWoodText = new TextGameObject("Wood: 0", 20, resourcesX, resourcesY - 20);
            numStoneText = new TextGameObject("Stone: 0", 20, resourcesX, resourcesY - 40);
            numApplesText = new TextGameObject("Apples: 0", 20, resourcesX, resourcesY - 60);
            numSaplingsText = new TextGameObject("Saplings: 0", 20, resourcesX, resourcesY - 80);
            energyText = new TextGameObject("Energy: 100", 20, Screen.width / 4, -Screen.height / 4);
            mtpsText = new TextGameObject("0mtps", 20, Screen.width / 4, Screen.height / 4);
        }

        public void update() {
            numGoldCoinsText.updateText("Gold Coins: " + player.getInventory().getNumItems(ItemType.GOLD_COIN));
            numWoodText.updateText("Wood: " + player.getInventory().getNumItems(ItemType.WOOD));
            numStoneText.updateText("Stone: " + player.getInventory().getNumItems(ItemType.STONE));
            numApplesText.updateText("Apples: " + player.getInventory().getNumItems(ItemType.APPLE));
            numSaplingsText.updateText("Saplings: " + player.getInventory().getNumItems(ItemType.SAPLING));
            energyText.updateText("Energy: " + player.getEnergy());
            mtpsText.updateText(tickCounter.getMtps() + "mtps");
        }
    }
}