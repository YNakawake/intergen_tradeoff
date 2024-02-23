# Supplementary Materials for Nakawake & Kobayashi (2024). ‘Exploring new technologies for the future generation: Exploration-exploitation trade-off in an intergenerational framework’
## The contents of this repository are as follows

all R files are in ipynb format (jupyter notebook)

+ `./`
    + `data_analysis/`: statistical analyis and data visualization codes, datasets are also included
        + `main_analysis.ipynb`: data analysis code in ipynb format (R)
        + `main_analysis.html`: data analysis code in html format (R)
        + `Revised_main_analysis.ipynb`: revised data analysis code (after receiving peer-review comments) in ipynb format (R)
        + `Revised_main_analysis.html`: revised data analysis code (after receiving peer-review comments)  in HTML format (R)
        + `maindata.csv`: the experimental dataset 
        + `maindata.csv`: the dataset of the postquestionnaire 
    +  `materials/` : materials used in the experiment
        + `instructions/`: instructions in Japanese
        + `Postquestionnaire/`: postquestionnaires in Japanese
        + `Prequestionnaire/`: prequestionnaires in Japanese
        + `Experimental_Program/`: experimental programme (VB NET)
    +  `simulations/` : simulation code and analysis
         + `exp_data.csv` : the dataset of the previous experiment used in the simulational analysis
            + Notice, this is the dataset from Nakawake & Kobayashi (2022): https://doi.org/10.1038/s41598-022-05031-2
            + see also https://github.com/YNakawake/projectile_neg
        + `Projectile_future_0.3.cpp`: simulation code (c++ with Boost Library)
            + Notice, this code is made by modifying 'Projectile_soc.3.3.cpp': https://github.com/YNakawake/projectile_neg/blob/main/simulation/Projectile_soc.3.3.cpp
        + `Simulation_Graph.iynb`: visualization and analysis code in ipynb format (R)
        + `Simulation_Graph.html`: visualization and analysis code in html format (R)
        + `simulation_exp.csv`: output of `Projectile_future_0.3.cpp`
        + `Simulation3.3.csv`: the result of simulation from Nakawake & Kobayashi (2022)
    + `README.md` : the file you are reading now
