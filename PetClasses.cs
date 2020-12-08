using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Challenges
{


    abstract class Pet
    {
        public enum PetClassificationTypes
        {
            Osteichthyes =1,
            Amphibia,
            Reptilia,
            Aves,
            Mammalia,
            Undetermined,
        }

        public string PetName { get; set; }
        public PetClassificationTypes PetClass { get; set; }
        public bool IndoorPet { get; set; }

        public Pet() { }
        public Pet(String petName, bool indoorPet)
        {
            PetName = petName;
            PetClass = AssignType();
            IndoorPet = indoorPet;
        }

        public virtual PetClassificationTypes AssignType() 
        {
            return PetClassificationTypes.Undetermined;
        }

    }
    class Mammal : Pet
    {
        public enum MammalTypes
        {
            Dog = 1,
            Cat,
            Hamster,
            Goat,
            Other,
        }
        public int Weight { get; set; }

        public string Color { get; set; }

        public MammalTypes MammalType { get; set; }

        public Mammal() { }
        public Mammal(String petName, bool indoorPet, int weight, string color)
        {
            PetName = petName;
            IndoorPet = indoorPet;
            PetClass = AssignType();
            Weight = weight;
            Color = color;
        }
        public override PetClassificationTypes AssignType()
        {
            return PetClassificationTypes.Mammalia;
        }
    }

    class Bird : Pet
    {
        public bool Carnivore { get; set; }
        public Bird() { }
        public Bird(String petName, bool indoorPet, bool carnivore)
        {
            PetName = petName;
            PetClass = AssignType();
            IndoorPet = indoorPet;
            Carnivore = carnivore;
        }
        public override PetClassificationTypes AssignType()
        {
            return PetClassificationTypes.Aves;
        }
    }
    class Reptile : Pet
    {
        public bool Aquadic { get; set; }
        public Reptile() { }
        public Reptile(String petName, bool indoorPet, bool aquadic)
        {
            PetName = petName;
            PetClass = AssignType();
            IndoorPet = indoorPet;
            Aquadic = aquadic;
        }
        public override PetClassificationTypes AssignType()
        {
            return PetClassificationTypes.Reptilia;
        }
    }

    class Amphamphibian : Pet
    {
        public bool LaysEggs { get; set; }
        public Amphamphibian() { }
        public Amphamphibian(String petName, bool indoorPet, bool laysEggs)
        {
            PetName = petName;
            PetClass = AssignType();
            IndoorPet = indoorPet;
            LaysEggs = laysEggs;
        }
        public override PetClassificationTypes AssignType()
        {
            return PetClassificationTypes.Amphibia;
        }
    }
    class Fish : Pet
    {
        public bool FreshWater { get; set; }

        public Fish(String petName, bool indoorPet, bool freshWater)
        {
            PetName = petName;
            PetClass = AssignType();
            IndoorPet = indoorPet;
            FreshWater = freshWater;
        }
        public override PetClassificationTypes AssignType()
        {
            return PetClassificationTypes.Osteichthyes;
        }
    }
}

