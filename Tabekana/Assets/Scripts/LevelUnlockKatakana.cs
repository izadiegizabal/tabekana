﻿using System.Collections;
        if (PlayerPrefs.HasKey("levelkata"))
        {
            GlobalVariables.levelUnlockKata = PlayerPrefs.GetInt("levelkata", GlobalVariables.levelUnlockKata);
        }

        if (GlobalVariables.levelUnlockKata >= level)