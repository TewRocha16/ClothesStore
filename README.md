# ClothesStore
This intervire aims to create a top-down style system for a shop, inventory, and movement.

For this interview, I began with character movement and animation, with no innovation here.
I set up colliders and implemented movement using Rigidbody. To ensure the character
faces the correct direction, I save the last pressed key and control it via a Blend Tree.
For interactions, I utilized polymorphism. I defined standard and repetitive behaviors in the
base class, with specific behaviors in their interactions.

For the shop system, I created a Scriptable Objects system to store the items and quantities
in both the player's and shopkeeper's inventories. Additionally, I added a currency variable to
the player. Populating both the shop and the player's inventory becomes easy using the
Scriptable Object.

I also created a stack of coins as an interactable object, allowing the player to earn currency
for use in the shop.

To conclude, at the mirror, the player has access to all the clothes in their inventory,
displayed in the mirror menu. When a piece of clothing is selected, it swaps the Animator
Controller from the unequipped character to the specific clothing's controller, containing
animations for the character wearing the chosen outfit. It's also possible to unequip the
armor by returning to the original Animator Controller. If the player sells armor they are
currently wearing, they inevitably become unequipped.

I assess that I performed well on the test; it was easy to execute within the specified
timeframe. I couldn't find any bugs, and I implemented all the required systems.
