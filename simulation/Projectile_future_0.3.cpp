#include <iostream>     // std::cout
#include <algorithm>    // std::random_shuffle
#include <vector>       // std::vector
#include <string>
#include <fstream>
#include <sstream>
#include <ostream>
#include <math.h>
#include <numeric>
#include <array>
#include <boost/random.hpp>
#include <time.h>

/*
Notice that this computer programme is rebuilt on Nakawake and Kobayashi (2021),
 which is avilable at https://github.com/YNakawake/projectile_neg/blob/main/simulation/Projectile_soc.3.3.cpp
Thus you will find some codes (although commented out) implemnted for the different purpose.
Please ignore codes for social learning.
 */


using namespace std;
using namespace boost;



void view(std::vector<int> v){for(size_t i=0; i<v.size(); i++){cout << v[i] << " ";}cout << endl;}
void view(std::vector<double> v){for(size_t i=0; i<v.size(); i++){cout << v[i] << " ";}cout << endl;}

void view(std::vector<std::vector<int> > vv){
  for(size_t i=0; i<vv.size(); i++){
    for(size_t j=0; j<vv[i].size(); j++){
      cout << vv[i][j] << " ";
    }
    cout << endl;
  }
}



// Gaussian function
double exp_distance(int X, int O){
	double  ans; double dist; double Xd; double Od;
	double sigma = 0.035;
	Xd = X + 0.0; Od = O + 0.0;
	dist = (-1) * pow ( ((Xd / 100.0) - (Od / 100.0)), 2);//^2
	ans = exp(dist / (2 * sigma));
	return ans;
}



// Fitness calculation function - not used 
int Calc_Fitness (double b1,int O1,int X1,double b2,int O2,int X2,double b3,int O3, int X3){
	int Fit;
	double t_bWs = 0.125;
	Fit= 1000 * (b1 * exp_distance(X1, O1) + b2 * exp_distance(X2, O2)+
				b3 * exp_distance(X3, O3)+ 0.125 * 1);
	return Fit;
}
 





double QuadDistance(int X, int O){
    double b = O;
    double ans;
    if (O < 51){b = 100 - O + 1;}
    ans = 1-((X-O)*(X-O))/(b*b);
    return ans;
}



int Calc_QuadFitness (double b1,int O1,int X1,double b2,int O2,int X2,double b3,int O3, int X3){
    int Fit;
    Fit= 1000 * (b1 * QuadDistance(X1, O1) + b2 *QuadDistance(X2, O2)+
                b3 * QuadDistance(X3, O3));
    return Fit;
}





// Truncating function for exceeding Min and Max
int CeilFloor (int v, int Minv, int  Maxv){
	if (v > Maxv){
		v = Maxv;
	} 
	if (v < Minv){
		v = Minv;
	}
	return v;
}

// Return -1 or 1, depending on the sign of number (if the number is 0 reuturn rondomly either -1  or 1)
int NegaPosiDeterminer (int Val, double Rnd){//Note that it requires random value to determine  the caes  that Val is 0, 
	int tempAns;
	if (Val > 1){tempAns = 1;} 
	else if (Val < 1) {tempAns = -1;}
	else {
		tempAns = -1;
		if (Rnd > 0.5){tempAns = 1;}
		}
	return tempAns;
}



int main (int argc, char const *argv[])
{
	
	//srand(time(0));
	srand(time(0));

	//Define rand()
	lagged_fibonacci1279 gen(static_cast<unsigned long>(time(0)));
	normal_distribution<> dst( 0.0, 1.0 );
	variate_generator<
		lagged_fibonacci1279, normal_distribution<>
		> norm_rand( gen, dst );
	
	minstd_rand n_gen(static_cast<unsigned long>(time(0)));
	uniform_real<> n_dst( 0, 1 );
	variate_generator<
		minstd_rand, uniform_real<>
		> uni_rand( n_gen, n_dst );



//****** paremeta setting do not change here
    
    
    int MaxID =10000; // Population Size
	int MaxTrial = 80;
	int MaxDimention = 3;
	int MaxMember = MaxDimention; //This is only used for the other study for social learing: Nakawake & Kobayashi (2021)

	int MaxPoint = 1000;/*
 	int SocLearingInterval = 3;

    int NEGATIVE = -1;  int POSITIVE  =  1;
	
    int DIRECTIONAL= 1; // Memory Only Algorithm (initally neamed as directional)
    int MOVE = 2; // Fixed Stride Algorithm (initally neamed as move)
    int MIRROR = 3; // Variable Stride Algorithm (initally neamed as move)
    */

    
    int TradeOff = 1;// trade off Exploration vs Explioitation
    int HUNT = 1;
    int KNAP = 0;
    
    int LastAction = 0;// MustGo



    // defining fitness landscape
    
    double bWl = 0.33;
    double bWw = 0.33;
    double bWt = 0.34;

/**************************/
    int EnvErrorSD = 5;
    //int SocLearnErrorM = 10;
    //int SocLearnErrorSD = 10;

    // Should be same as Seasons
    // array<int, Season>
    
    int OL = 70;
    int OW = 48;
    int OT = 11;
    
    int InitialL = 14;
    int InitialW = 6;
    int InitialT = 83;

    int LearingLength = 25;

    /*array<int, 3> OL1 = {30, 36, 39};
    array<int, 3> OW1 = {63, 4, 17};
    array<int, 3> OT1 = {34, 57, 84};

    
    // since the landscape is unimodal those values are not used
    array<int, 3> OL2 = {99, 99 ,99};
    array<int, 3> OW2 = {88, 88, 88};
    array<int, 3> OT2 = {77, 77, 77};

    array<int, 3> InitialL = {52, 58, 61};
    array<int, 3> InitialW = {22, 73, 79};
    array<int, 3> InitialT = {75, 82, 38};
    //array<int, 3> InitialS = {2, 3, 2};//shape is not used

	int SeasonNum = 1;*/
    int IndLearingOpp = 1;//0:No Ind Learning, 1: Do Ind Learning
     
    
    //*************************************************************
    //******************** SET THE PARAMETA HERE*******************
    // You can change below to test social learing algorithm, condition (asocial/negative/positive) and seasons
    
    
    
    /*
    int SocLearning = 0; // 0= asocial, 1 = social
    int SocLearningWay = MIRROR; //,DIRECTIONAL(memory only), MOVE(fixed stride), MIRROR(variable stride)
    int SocLearningCondition =1; //-1: Negative,  ; 1: Positive
    // If you want asocial leraing then you should choose SocLearing = 0, instead of setting here
     */
   // int Season = 3;--Season;//Start From 0 Thus Should be -1 (don't think just type Season 1 or 2 or 3)
    


    

    

    //*************************************************************
    //*************************************************************
   

	

    //calculate var
    double tM = 0.0;
    double tSM = 0.0;
    double tVar = 0.0;
	double tLastF = 0.0;

	int CurPerformance;
	int CurErroedPeformance;
    int Fitness = 0;
    int erroredFitness = 0;

    vector <int> PosNegMemory (MaxDimention, 0); //Memory for Learning
    int tempNP;double tempUniRnd;// using to fill PosNegMemory

    vector <int> SocLearningDiffMemory (MaxDimention, 0);
    vector <int> SocModificationDirection (MaxDimention, 0);




    vector <int> CurArrowParameta (7, 0); // Current Shape of Arrowhead //L, W, T, fitness errored Fitness
    int L = 0; int W = 1; int T = 2; int F = 3; int eF = 4; int lF = 5; int cF = 6;int Md = 7;
    int ChangeDimention =  0;
    int ChangeDistance = 5;


	/*vector < vector<int> > OfflinePerformance (MaxTrial,vector<int>(MaxMember,0));*/
    
    
    /*

	vector < vector<int> > HunterMat (MaxMember, vector<int>(MaxDimention+2,0));
    int L = 0; int W = 1; int T = 2; int F = 3; int eF = 4; int lF = 5; int cF = 6;int Md = 7;
    //ef = errored fitness, lf = last fitness, int cF = cumulatively erned money, Md = moode
     */

	vector <int> SumOfflineVect (MaxTrial, 0);
    vector <double> SqSumOfflineVect (MaxTrial, 0);
    
    
    
    
    
    vector <double> SumEarnedVec (MaxID, 0);
    vector <double> SqSumEarnedVec (MaxID, 0);
	int  CountExp = 0;
	vector <double> LastArrowPerformance (MaxID, 0);
    
    vector <double> SaveLearingPeformance;
    vector <double> SaveLearingPeformanceSq;


	//vector <int> SocLearingOpp(MaxTrial, 0);


	//SocLearingOpp[2] = 0;//To Avid Erro
	/*

	if (SocLearnifng == 1){
	for (int ii=2; ii < MaxTrial; ii++){
		if ((ii % SocLearingInterval) == 2){
			SocLearingOpp[ii] = 1;
		}
	}
	}

	*/

	int ErrorCounter = 0;
	//Start Loop

	
	vector <double> tempV;
	double tempval;


	for (LearingLength = 1; LearingLength < MaxTrial; LearingLength = LearingLength + 2){

	//for (LearingLength = 100; LearingLength < 101; LearingLength = LearingLength + 2){

		//Reset variables
    vector <int> SocLearningDiffMemory (MaxDimention, 0);
    vector <int> SocModificationDirection (MaxDimention, 0);
    vector <int> CurArrowParameta (MaxDimention+2, 0);
	vector <int> SumOfflineVect (MaxTrial, 0);
    vector <double> SqSumOfflineVect (MaxTrial, 0);
	vector < vector<int> > ArrowPerformance (MaxTrial,vector<int>(MaxMember,0));
	vector <double> SumEarnedVec (MaxID, 0);
    vector <double> SqSumEarnedVec (MaxID, 0);
	vector <double> LastArrowPerformance (MaxID, 0);
        
        CountExp = 0;

	
		

	for (int CurID =0; CurID < MaxID; CurID++){


		//cout<<CurID;

		//cout  << endl;  //++++++++++++++++//
		vector <int> CurArrowParameta (MaxDimention+2, 0);
        
        /*
		vector < vector<int> > ArrowPerformance (MaxTrial,vector<int>(MaxMember,0));
		vector < vector<int> > HunterMat (MaxMember, vector<int>(MaxDimention+2,0));
		vector <int> SocLearningDiffMemory (MaxDimention, 0);
         
         */
		//cout << "A";
	//for (int CurID; CurID < 1; CurID++){
		for (int CurTrial = 0; CurTrial < MaxTrial; CurTrial++){
			

			//cout<<CurTrial<<",";			//cout << CurTrial;
			
			// Step1. Arrowhead Making

			//  In the first trial, the  participant use the defalt value
			if (CurTrial == 0){ // Here, have to use transmitted Arrowhead


				CurArrowParameta[L] = InitialL;
				CurArrowParameta[W] = InitialW;
				CurArrowParameta[T] = InitialT;



				Fitness = Calc_QuadFitness(
					//Fitness = Calc_Fitness(
					bWl, OL, CurArrowParameta[L],
					bWw, OW, CurArrowParameta[W],
				 	bWt, OT, CurArrowParameta[T]);

				erroredFitness = Fitness + norm_rand() * EnvErrorSD; 

				CurArrowParameta[F] = Fitness;
				CurArrowParameta[eF] = erroredFitness;
                CurArrowParameta[lF] = erroredFitness;
                CurArrowParameta[cF] = Fitness;


				SumOfflineVect[CurTrial] = SumOfflineVect[CurTrial] + Fitness;
                SqSumOfflineVect[CurTrial] = SqSumOfflineVect[CurTrial] + Fitness*Fitness;
				
				
				// Deciding Direction Randomly
				for (int m = 0; m < MaxDimention; m++){
					PosNegMemory [m] = -1;
					tempUniRnd = uni_rand();
					if (tempUniRnd > 0.5){PosNegMemory [m] = 1;}
				}
                
                LastAction = HUNT;

				/*
				
				cout<<endl<<endl<<CurTrial<<"****"<<endl;


				if (SocLearingOpp[CurTrial] == 1){
				view (HunterMat);

				}
				view (CurArrowParameta);

				cout<<"****"<<endl<<endl;

				*/
				


			//  From the sedond trial, the participant modified arrowhead 
			} else {
				if(IndLearingOpp == 1) {
                    
                    
                    
                    if (LearingLength >= CurTrial && LastAction == HUNT){// Learing/Knap=Exploration
                        tempUniRnd = uni_rand() * 3;
                        ChangeDimention = L;
                        if (tempUniRnd > 1) { ChangeDimention = W; }
                        if (tempUniRnd > 2) { ChangeDimention = T; }

                        CurArrowParameta[ChangeDimention] = CurArrowParameta[ChangeDimention] + PosNegMemory[ChangeDimention] * ChangeDistance;
                        CurArrowParameta[ChangeDimention] = CeilFloor(CurArrowParameta[ChangeDimention], 1, 100);
                        LastAction = KNAP;


						// offline perforamnce

						Fitness = Calc_QuadFitness(
					    //Fitness = Calc_Fitness(
                            bWl, OL, CurArrowParameta[L],
                            bWw, OW, CurArrowParameta[W],
                    	         bWt, OT, CurArrowParameta[T]);
						Fitness = CeilFloor(Fitness, 1, 1000);

						erroredFitness = Fitness + (norm_rand() * EnvErrorSD);
						erroredFitness = CeilFloor(erroredFitness, 1, 1000);
                    	CurArrowParameta[F] = Fitness;
                   		 CurArrowParameta[eF] = erroredFitness;
						SumOfflineVect[CurTrial] = SumOfflineVect[CurTrial] + Fitness;
                    	SqSumOfflineVect[CurTrial] = SqSumOfflineVect[CurTrial] + Fitness*Fitness;


						CurArrowParameta[F] = Fitness;
                  	  CurArrowParameta[eF] = erroredFitness;


					//cout<<"KNAP,";
                    
					CountExp++;
                    }else{ //Hunting=exploration
					



                    Fitness = Calc_QuadFitness(
					//Fitness = Calc_Fitness(
                            bWl, OL, CurArrowParameta[L],
                            bWw, OW, CurArrowParameta[W],
                             bWt, OT, CurArrowParameta[T]);
					Fitness = CeilFloor(Fitness, 1, 1000);

					erroredFitness = Fitness + (norm_rand() * EnvErrorSD);
					erroredFitness = CeilFloor(erroredFitness, 1, 1000);
                    CurArrowParameta[F] = Fitness;
                    CurArrowParameta[eF] = erroredFitness;
            





					SumOfflineVect[CurTrial] = SumOfflineVect[CurTrial] + Fitness;



					
                        // Update Dimention Memory; note [lF], since compare agains the previous offline but rather agains the last husnt performance
                        if ((erroredFitness - CurArrowParameta[lF]) > 0) {
                            PosNegMemory[ChangeDimention] = PosNegMemory[ChangeDimention];
                        }
                        else {
                            PosNegMemory[ChangeDimention] = PosNegMemory[ChangeDimention] * (-1);
                        }
                        
                        SumEarnedVec[CurID] = SumEarnedVec[CurID]  + erroredFitness;
					CurArrowParameta[lF] = erroredFitness;
                	CurArrowParameta[cF] = Fitness;


                        
                        LastAction = HUNT;
                    //	cout<<"HUNT,";
                        
                    }

                if (CurTrial == MaxTrial){
                    LastArrowPerformance[CurID] = Fitness;
				}
				


				} //End if IndlearingOpp



			} //end InD



			// Step2. 

			//view (CurArrowParameta);
			//cout<<Fitness<<","; //++++++++++++++++//

		}//trial
	}//



	

	
	//view(SumOfflineVect);
    //view(SqSumOfflineVect);


	
	/*

	for (int gg = 0; gg < MaxTrial; gg ++){
		cout<< "," <<(SumOfflineVect.at(gg))*1.00/MaxID;
	
	}
	*/

    /*
    cout<<endl;
    for (int kk = 0; kk < MaxTrial; kk ++){
        
        tM =SumOfflineVect.at(kk)*1.00/MaxID;
        tSM = SqSumOfflineVect.at(kk)*1.00/MaxID;
        tVar = tSM - tM*tM;
        cout<< "," <<tVar;
    }
    */
 
	/*
    for (int kk = 0; kk < MaxTrial; kk ++){
        
        tM =SumOfflineVect.at(kk)*1.00/MaxID;
        tSM = SqSumOfflineVect.at(kk)*1.00/MaxID;
        tVar = tSM - tM*tM;
        cout<< "," << sqrt(tVar)/sqrt(MaxID);
    }
	 cout<<endl;
	 */
        
        
    
	tM = 0;
	tSM = 0;
	tVar = 0;
    for (int ii = 0; ii <MaxID; ii ++){
		tM = tM + SumEarnedVec.at(ii)/MaxTrial;
		tSM = tSM + (SumEarnedVec.at(ii)/MaxTrial)*(SumEarnedVec.at(ii)/MaxTrial);
    }
	tM = tM/MaxID;
	tVar = tSM/(MaxTrial*MaxTrial) - tM/(MaxTrial) * tM/(MaxTrial);
 
	cout << "MaxTrial," << MaxTrial << ",Learning," << LearingLength <<  ",N," << MaxID << ",M," << tM << ",Var," << tVar << "," << CountExp/MaxID << endl;

}//LearingLength

	return 0;

 }





