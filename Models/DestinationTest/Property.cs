using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property", Schema = "dbo")]
    public partial class Property
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("propid")]
        public int Propid { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city")]
        public int? City { get; set; }

        [Column("zip")]
        public string Zip { get; set; }

        [Column("agentid")]
        public int? Agentid { get; set; }

        public Agent Agent { get; set; }

        [Column("property_type")]
        public int? PropertyType { get; set; }

        [Column("Square_footage")]
        public string SquareFootage { get; set; }

        [Column("Year_built")]
        public string YearBuilt { get; set; }

        public string Bedrooms { get; set; }

        public string Baths { get; set; }

        public string Floors { get; set; }

        [Column("Garage_Size")]
        public string GarageSize { get; set; }

        [Column("Lot_size")]
        public string LotSize { get; set; }

        public bool? Alarm { get; set; }

        [Column("Assisted_Living")]
        public bool? AssistedLiving { get; set; }

        [Column("Carpeted_Floors")]
        public bool? CarpetedFloors { get; set; }

        [Column("Central_AC")]
        public bool? CentralAc { get; set; }

        public bool? ClubHouse { get; set; }

        [Column("Controlled_Access")]
        public bool? ControlledAccess { get; set; }

        public bool? Courtyard { get; set; }

        public bool? Fireplace { get; set; }

        [Column("Fitness_Center")]
        public bool? FitnessCenter { get; set; }

        [Column("Gas_Range")]
        public bool? GasRange { get; set; }

        [Column("Nature_Bike_Paths")]
        public bool? NatureBikePaths { get; set; }

        public bool? Patio { get; set; }

        [Column("Playground_Park")]
        public bool? PlaygroundPark { get; set; }

        public bool? Pool { get; set; }

        [Column("Public_Transportation")]
        public bool? PublicTransportation { get; set; }

        [Column("Retirement_Community")]
        public bool? RetirementCommunity { get; set; }

        [Column("Spa_Jucuzzi")]
        public bool? SpaJucuzzi { get; set; }

        [Column("Sports_Complex")]
        public bool? SportsComplex { get; set; }

        [Column("Tennis_Courts")]
        public bool? TennisCourts { get; set; }

        [Column("Water_Front")]
        public bool? WaterFront { get; set; }

        [Column("WheelChair_Accessible")]
        public bool? WheelChairAccessible { get; set; }

        [Column("Wood_Floors")]
        public bool? WoodFloors { get; set; }

        [Column("Additional_Features")]
        public string AdditionalFeatures { get; set; }

        public double? Price { get; set; }

        [Column("Current_Loan_Type")]
        public int? CurrentLoanType { get; set; }

        [Column("Sellers_Flexibility")]
        public string SellersFlexibility { get; set; }

        [Column("Date_Created")]
        public DateTime? DateCreated { get; set; }

        [Column("Date_last_updated")]
        public DateTime? DateLastUpdated { get; set; }

        public int? Createdby { get; set; }

        public int? Updatedby { get; set; }

        [Column("Contact_First_Name")]
        public string ContactFirstName { get; set; }

        [Column("Contact_Last_Name")]
        public string ContactLastName { get; set; }

        [Column("Contact_Info")]
        public string ContactInfo { get; set; }

        public bool? Views { get; set; }

        public string Description { get; set; }

        public bool? Furnished { get; set; }

        [Column("Vacation_Rental")]
        public bool? VacationRental { get; set; }

        [Column("Top_Property")]
        public bool? TopProperty { get; set; }

        [Column("Main_image")]
        public string MainImage { get; set; }

        public string Name { get; set; }

        public string Neighborhood { get; set; }

        public double? Deposit { get; set; }

        public double? Rent { get; set; }

        public string Sleeps { get; set; }

        [Column("Lease_Term")]
        public string LeaseTerm { get; set; }

        public DateTime? Available { get; set; }

        public string Increment { get; set; }

        public int? Status { get; set; }

        public Status Status1 { get; set; }

        public bool? UnFurnished { get; set; }

        [Column("Res_Comm")]
        public string ResComm { get; set; }

        [Column("c_shopping_center")]
        public bool? CShoppingCenter { get; set; }

        [Column("c_office_building")]
        public bool? COfficeBuilding { get; set; }

        [Column("c_neighborhood")]
        public bool? CNeighborhood { get; set; }

        [Column("c_stand_alone")]
        public bool? CStandAlone { get; set; }

        [Column("c_nnn_lease")]
        public bool? CNnnLease { get; set; }

        [Column("c_modified_gross")]
        public bool? CModifiedGross { get; set; }

        [Column("c_full_service")]
        public bool? CFullService { get; set; }

        [Column("c_elevator")]
        public bool? CElevator { get; set; }

        [Column("c_conference_room")]
        public bool? CConferenceRoom { get; set; }

        [Column("c_air_conditioning")]
        public bool? CAirConditioning { get; set; }

        [Column("c_carpeted")]
        public bool? CCarpeted { get; set; }

        [Column("c_storage")]
        public bool? CStorage { get; set; }

        [Column("c_security")]
        public bool? CSecurity { get; set; }

        [Column("c_parking")]
        public bool? CParking { get; set; }

        [Column("c_concrete_floors")]
        public bool? CConcreteFloors { get; set; }

        [Column("c_private_restroom")]
        public bool? CPrivateRestroom { get; set; }

        [Column("c_community_restroom")]
        public bool? CCommunityRestroom { get; set; }

        [Column("c_pay_utilities")]
        public bool? CPayUtilities { get; set; }

        [Column("c_utilies_included")]
        public bool? CUtiliesIncluded { get; set; }

        [Column("c_Property_management")]
        public bool? CPropertyManagement { get; set; }

        [Column("c_sub_lease")]
        public bool? CSubLease { get; set; }

        [Column("c_per_sq")]
        public double? CPerSq { get; set; }

        [Column("c_type")]
        public string CType { get; set; }

        [Column("c_suitenum")]
        public string CSuitenum { get; set; }

        [Column("c_building_size")]
        public byte[] CBuildingSize { get; set; }

        [Column("description_back")]
        public string DescriptionBack { get; set; }

        public bool? Lakeview { get; set; }

        [Column("Mountain_view")]
        public bool? MountainView { get; set; }

        [Column("rates")]
        public string Rates { get; set; }

        [Column("videopath")]
        public string Videopath { get; set; }

        [Column("Near_hiking_Trail")]
        public bool? NearHikingTrail { get; set; }

        [Column("Pool_Table")]
        public bool? PoolTable { get; set; }

        public bool? Spa { get; set; }

        [Column("Foos_ball")]
        public bool? FoosBall { get; set; }

        [Column("Parking_Spaces")]
        public string ParkingSpaces { get; set; }

        [Column("Pets_Ok")]
        public bool? PetsOk { get; set; }

        [Column("Sledding_Hill")]
        public bool? SleddingHill { get; set; }

        [Column("BBCity")]
        public string Bbcity { get; set; }

        [Column("sleep_num")]
        public int? SleepNum { get; set; }

        [Column("cleaningfee")]
        public double? Cleaningfee { get; set; }

        [Column("code")]
        public string Code { get; set; }

        [Column("instructions")]
        public string Instructions { get; set; }

        [Column("Internal_notes")]
        public string InternalNotes { get; set; }

        public bool? Wedding { get; set; }

        [Column("nearlake")]
        public bool? Nearlake { get; set; }

        [Column("nearsnowsummit")]
        public bool? Nearsnowsummit { get; set; }

        [Column("nearbearmtn")]
        public bool? Nearbearmtn { get; set; }

        [Column("nearvillage")]
        public bool? Nearvillage { get; set; }

        [Column("gametable")]
        public bool? Gametable { get; set; }

        [Column("InternalNotes")]
        public string InternalNotes1 { get; set; }

        [Column("internet")]
        public bool? Internet { get; set; }

        public string HomeGuide { get; set; }

        [Column("inspectedby")]
        public bool? Inspectedby { get; set; }

        [Column("alarmcode")]
        public string Alarmcode { get; set; }

        [Column("luxury")]
        public bool? Luxury { get; set; }

        [Column("boatparking")]
        public bool? Boatparking { get; set; }

        [Column("cleaner")]
        public string Cleaner { get; set; }

        [Column("revenue")]
        public double? Revenue { get; set; }

        [Column("defaultcleaner")]
        public bool? Defaultcleaner { get; set; }

        [Column("cleanerassigned")]
        public int? Cleanerassigned { get; set; }

        public PropertyCleaner PropertyCleaner { get; set; }

        [Column("sleeping")]
        public string Sleeping { get; set; }

        public string Closinginstructions { get; set; }

        public double? SupplyCost { get; set; }

        [Column("mgtrate")]
        public double? Mgtrate { get; set; }

        [Column("owner")]
        public int? Owner { get; set; }

        [Column("mpartner")]
        public string Mpartner { get; set; }

        [Column("muser")]
        public string Muser { get; set; }

        [Column("mtype")]
        public string Mtype { get; set; }

        [Column("bitIsBookingOnline")]
        public bool? BitIsBookingOnline { get; set; }

        [Column("inspection")]
        public string Inspection { get; set; }

        [Column("castle")]
        public bool? Castle { get; set; }

        [Column("metadesc")]
        public string Metadesc { get; set; }

        [Column("metakeyword")]
        public string Metakeyword { get; set; }

        [Column("mdesc")]
        public string Mdesc { get; set; }

        [Column("private")]
        public string Private { get; set; }

        [Column("snowremoval")]
        public int? Snowremoval { get; set; }

        [Column("shovel")]
        public int? Shovel { get; set; }

        [Column("keypos")]
        public int? Keypos { get; set; }

        [Column("spaservice")]
        public int? Spaservice { get; set; }

        public string PropertyHeadlines { get; set; }

        public string PropHeadlines { get; set; }

        [Column("lat")]
        public string Lat { get; set; }

        [Column("long")]
        public string Long { get; set; }

        [Column("inspectiondate")]
        public DateTime? Inspectiondate { get; set; }

        [Column("cityinspectdate")]
        public DateTime? Cityinspectdate { get; set; }

        [Column("showonvrbo")]
        public bool? Showonvrbo { get; set; }

        [Column("showonairbnb")]
        public bool? Showonairbnb { get; set; }

        [Column("showonflipkey")]
        public bool? Showonflipkey { get; set; }

        [Column("showonbblp")]
        public bool? Showonbblp { get; set; }

        [Column("inspectiondatemgt")]
        public DateTime? Inspectiondatemgt { get; set; }

        public bool? IsRently { get; set; }

        [Column("cleaningfeebid")]
        public double? Cleaningfeebid { get; set; }

        [Column("cleaningfeespring")]
        public double? Cleaningfeespring { get; set; }

        public DateTime? CleanerPaidDate { get; set; }

        [Column("ShowOnDBB")]
        public bool? ShowOnDbb { get; set; }

        public decimal? OwnerCleaningFee { get; set; }

        public bool? CheckInAgreementExpress { get; set; }

        public bool? IsCleaned { get; set; }

        [Column("snownotes")]
        public string Snownotes { get; set; }

        public bool? Oven { get; set; }

        public bool? Microwave { get; set; }

        public bool? Toaster { get; set; }

        [Column("Coffee_Maker")]
        public bool? CoffeeMaker { get; set; }

        public bool? DishesAndUtensils { get; set; }

        public bool? Dishwasher { get; set; }

        public bool? Grill { get; set; }

        public bool? Kitchen { get; set; }

        public bool? Refrigerator { get; set; }

        public bool? Television { get; set; }

        [Column("Video_Library")]
        public bool? VideoLibrary { get; set; }

        [Column("Music_Library")]
        public bool? MusicLibrary { get; set; }

        [Column("PingPong_Table")]
        public bool? PingPongTable { get; set; }

        public bool? Books { get; set; }

        [Column("DVDPlayer")]
        public bool? Dvdplayer { get; set; }

        public bool? Football { get; set; }

        public bool? Games { get; set; }

        [Column("Satellite_Cable")]
        public bool? SatelliteCable { get; set; }

        public bool? Stereo { get; set; }

        public bool? Toys { get; set; }

        public bool? VideoGames { get; set; }

        public bool? Sauna { get; set; }

        [Column("Communal_Pool")]
        public bool? CommunalPool { get; set; }

        public bool? Bicycles { get; set; }

        public bool? Boat { get; set; }

        public bool? Golf { get; set; }

        public bool? Rural { get; set; }

        public bool? Town { get; set; }

        public bool? DiningArea { get; set; }

        public bool? DiningHighChair { get; set; }

        public bool? DiningRoom { get; set; }

        [Column("PoolTable")]
        public bool? PoolTable1 { get; set; }

        public bool? Garden { get; set; }

        [Column("SkiIn_SkiOut")]
        public bool? SkiInSkiOut { get; set; }

        [Column("snowremovalpy")]
        public int? Snowremovalpy { get; set; }

        [Column("ShowOnBB")]
        public bool? ShowOnBb { get; set; }

        public DateTime? DateClosed { get; set; }

        public bool? IsExpressCheckInApp { get; set; }

        public string DescNew { get; set; }

        public bool? DedicatedWorkspace { get; set; }

        [Column("EVCharger")]
        public bool? Evcharger { get; set; }

        public bool? Crib { get; set; }

        public bool? Gym { get; set; }

        public bool? Fire { get; set; }

        public bool? CookingBasics { get; set; }

        public string AirbnbDesc { get; set; }

        public string AirbnbTitle { get; set; }

        [Column("Amnt_HairDryer")]
        public bool? AmntHairDryer { get; set; }

        [Column("Amnt_Heating")]
        public bool? AmntHeating { get; set; }

        [Column("Amnt_BathTub")]
        public bool? AmntBathTub { get; set; }

        [Column("Amnt_Bidet")]
        public bool? AmntBidet { get; set; }

        [Column("Amnt_BodySoap")]
        public bool? AmntBodySoap { get; set; }

        [Column("Amnt_CleaningProducts")]
        public bool? AmntCleaningProducts { get; set; }

        [Column("Amnt_HotWater")]
        public bool? AmntHotWater { get; set; }

        [Column("Amnt_OutdoorShower")]
        public bool? AmntOutdoorShower { get; set; }

        [Column("Amnt_Shampoo")]
        public bool? AmntShampoo { get; set; }

        [Column("Amnt_ShowerGel")]
        public bool? AmntShowerGel { get; set; }

        [Column("Amnt_BedLinens")]
        public bool? AmntBedLinens { get; set; }

        [Column("Amnt_ClothingStorage")]
        public bool? AmntClothingStorage { get; set; }

        [Column("Amnt_ClotheDryingRack")]
        public bool? AmntClotheDryingRack { get; set; }

        [Column("Amnt_ExtraPillowsBlankets")]
        public bool? AmntExtraPillowsBlankets { get; set; }

        [Column("Amnt_Hangers")]
        public bool? AmntHangers { get; set; }

        [Column("Amnt_Iron")]
        public bool? AmntIron { get; set; }

        [Column("Amnt_MosquitoNet")]
        public bool? AmntMosquitoNet { get; set; }

        [Column("Amnt_RoomDarkeningShades")]
        public bool? AmntRoomDarkeningShades { get; set; }

        [Column("Amnt_Safe")]
        public bool? AmntSafe { get; set; }

        [Column("Amnt_ArcadeGames")]
        public bool? AmntArcadeGames { get; set; }

        [Column("Amnt_BowlingAlley")]
        public bool? AmntBowlingAlley { get; set; }

        [Column("Amnt_ClimbingWall")]
        public bool? AmntClimbingWall { get; set; }

        [Column("Amnt_Ethernet")]
        public bool? AmntEthernet { get; set; }

        [Column("Amnt_ExerciseEquipment")]
        public bool? AmntExerciseEquipment { get; set; }

        [Column("Amnt_LazerTag")]
        public bool? AmntLazerTag { get; set; }

        [Column("Amnt_LifeSizeGames")]
        public bool? AmntLifeSizeGames { get; set; }

        [Column("Amnt_MiniGolf")]
        public bool? AmntMiniGolf { get; set; }

        [Column("Amnt_MovieTheater")]
        public bool? AmntMovieTheater { get; set; }

        [Column("Amnt_Piano")]
        public bool? AmntPiano { get; set; }

        [Column("Amnt_RecordPlayer")]
        public bool? AmntRecordPlayer { get; set; }

        [Column("Amnt_SkateRamp")]
        public bool? AmntSkateRamp { get; set; }

        [Column("Amnt_BabyBath")]
        public bool? AmntBabyBath { get; set; }

        [Column("Amnt_BabyMonitor")]
        public bool? AmntBabyMonitor { get; set; }

        [Column("Amnt_ChildrenBike")]
        public bool? AmntChildrenBike { get; set; }

        [Column("Amnt_ChildrenPlayroom")]
        public bool? AmntChildrenPlayroom { get; set; }

        [Column("Amnt_BabySafetyGates")]
        public bool? AmntBabySafetyGates { get; set; }

        [Column("Amnt_BabysitterRecommendations")]
        public bool? AmntBabysitterRecommendations { get; set; }

        [Column("Amnt_ChangingTable")]
        public bool? AmntChangingTable { get; set; }

        [Column("Amnt_ChildrenDinnerware")]
        public bool? AmntChildrenDinnerware { get; set; }

        [Column("Amnt_FireplaceGuards")]
        public bool? AmntFireplaceGuards { get; set; }

        [Column("Amnt_OutdoorPlayground")]
        public bool? AmntOutdoorPlayground { get; set; }

        [Column("Amnt_OutletCovers")]
        public bool? AmntOutletCovers { get; set; }

        [Column("Amnt_TravelCrib")]
        public bool? AmntTravelCrib { get; set; }

        [Column("Amnt_TableCornerGuards")]
        public bool? AmntTableCornerGuards { get; set; }

        [Column("Amnt_WindowGuards")]
        public bool? AmntWindowGuards { get; set; }

        [Column("Amnt_CeilingFan")]
        public bool? AmntCeilingFan { get; set; }

        [Column("Amnt_PortableFans")]
        public bool? AmntPortableFans { get; set; }

        [Column("Amnt_CarbonMonoxideAlram")]
        public bool? AmntCarbonMonoxideAlram { get; set; }

        [Column("Amnt_FireExtinguisher")]
        public bool? AmntFireExtinguisher { get; set; }

        [Column("Amnt_FirstAidKit")]
        public bool? AmntFirstAidKit { get; set; }

        [Column("Amnt_SmokeAlarm")]
        public bool? AmntSmokeAlarm { get; set; }

        [Column("Amnt_PocketWifi")]
        public bool? AmntPocketWifi { get; set; }

        [Column("Amnt_BakingSheet")]
        public bool? AmntBakingSheet { get; set; }

        [Column("Amnt_BarbecueUtensils")]
        public bool? AmntBarbecueUtensils { get; set; }

        [Column("Amnt_BreadMaker")]
        public bool? AmntBreadMaker { get; set; }

        [Column("Amnt_Belnder")]
        public bool? AmntBelnder { get; set; }

        [Column("Amnt_Coffee")]
        public bool? AmntCoffee { get; set; }

        [Column("Amnt_CookingBasics")]
        public bool? AmntCookingBasics { get; set; }

        [Column("Amnt_Freezer")]
        public bool? AmntFreezer { get; set; }

        [Column("Amnt_HotWaterKettle")]
        public bool? AmntHotWaterKettle { get; set; }

        [Column("Amnt_Kitchenette")]
        public bool? AmntKitchenette { get; set; }

        [Column("Amnt_MiniFridge")]
        public bool? AmntMiniFridge { get; set; }

        [Column("Amnt_RiceMaker")]
        public bool? AmntRiceMaker { get; set; }

        [Column("Amnt_Stove")]
        public bool? AmntStove { get; set; }

        [Column("Amnt_TrashCompactor")]
        public bool? AmntTrashCompactor { get; set; }

        [Column("Amnt_WineGlass")]
        public bool? AmntWineGlass { get; set; }

        [Column("Amnt_BeachAccess")]
        public bool? AmntBeachAccess { get; set; }

        [Column("Amnt_LakeAccess")]
        public bool? AmntLakeAccess { get; set; }

        [Column("Amnt_LaundromatNearby")]
        public bool? AmntLaundromatNearby { get; set; }

        [Column("Amnt_PrivateEntrance")]
        public bool? AmntPrivateEntrance { get; set; }

        [Column("Amnt_ResortAccess")]
        public bool? AmntResortAccess { get; set; }

        [Column("Amnt_Waterfront")]
        public bool? AmntWaterfront { get; set; }

        [Column("Amnt_Backyard")]
        public bool? AmntBackyard { get; set; }

        [Column("Amnt_BeachEssentials")]
        public bool? AmntBeachEssentials { get; set; }

        [Column("Amnt_FirePit")]
        public bool? AmntFirePit { get; set; }

        [Column("Amnt_Hammock")]
        public bool? AmntHammock { get; set; }

        [Column("Amnt_Kayak")]
        public bool? AmntKayak { get; set; }

        [Column("Amnt_OutdoorDiningArea")]
        public bool? AmntOutdoorDiningArea { get; set; }

        [Column("Amnt_OutdoorFurniture")]
        public bool? AmntOutdoorFurniture { get; set; }

        [Column("Amnt_OutdoorKitchen")]
        public bool? AmntOutdoorKitchen { get; set; }

        [Column("Amnt_SunLoungers")]
        public bool? AmntSunLoungers { get; set; }

        [Column("Amnt_Elevator")]
        public bool? AmntElevator { get; set; }

        [Column("Amnt_FreeParking")]
        public bool? AmntFreeParking { get; set; }

        [Column("Amnt_HockeyRink")]
        public bool? AmntHockeyRink { get; set; }

        [Column("Amnt_SingleLevelHome")]
        public bool? AmntSingleLevelHome { get; set; }

        [Column("Amnt_BattingCage")]
        public bool? AmntBattingCage { get; set; }

        [Column("Amnt_Essentials")]
        public bool? AmntEssentials { get; set; }

        public bool? GarageParking { get; set; }

        public bool? Dock { get; set; }

        public bool? AlwaysAudit { get; set; }

        [Column("Amnt_Theater")]
        public bool? AmntTheater { get; set; }

        public bool? AngelsCamp { get; set; }

        public ICollection<AnnualSurvey> AnnualSurveys { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public ICollection<BookingsLogic> BookingsLogics { get; set; }

        public ICollection<Channel> Channels { get; set; }

        public ICollection<Currentdiscount> Currentdiscounts { get; set; }

        public ICollection<DailyRatesBasedOnPropertyRate> DailyRatesBasedOnPropertyRates { get; set; }

        public ICollection<FilterDataForBulkSmsMail> FilterDataForBulkSmsMails { get; set; }

        public ICollection<MarketingReview> MarketingReviews { get; set; }

        public ICollection<Performa> Performas { get; set; }

        public ICollection<PromoCode> PromoCodes { get; set; }

        public ICollection<PropertyBed> PropertyBeds { get; set; }

        public ICollection<PropertyExpense> PropertyExpenses { get; set; }

        public ICollection<PropertyImprovement> PropertyImprovements { get; set; }

        public ICollection<PropertyMgt> PropertyMgts { get; set; }

        public ICollection<PropertyRate> PropertyRates { get; set; }

        public ICollection<PropertyRatesVrbo> PropertyRatesVrbos { get; set; }

        public ICollection<PropertyWarning> PropertyWarnings { get; set; }

        public ICollection<PropertyBackToBackBookingsRestrict> PropertyBackToBackBookingsRestricts { get; set; }

        public ICollection<PropertyRatesDaily> PropertyRatesDailies { get; set; }

        public ICollection<PropertyVisitCount> PropertyVisitCounts { get; set; }

        public ICollection<TblMultiDayDiscount> TblMultiDayDiscounts { get; set; }
    }
}