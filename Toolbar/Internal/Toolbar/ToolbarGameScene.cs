﻿/*
Copyright (c) 2013-2016, Maik Schreiber
All rights reserved.

Redistribution and use in source and binary forms, with or without modification,
are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this
   list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice,
   this list of conditions and the following disclaimer in the documentation
   and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toolbar {
	internal enum ToolbarGameScene {
		LOADING,
		LOADINGBUFFER,
		MAINMENU,
		SETTINGS,
		CREDITS,
		SPACECENTER,
		EDITOR,
		FLIGHT,
		TRACKSTATION,
		PSYSTEM,

		FLIGHTMAP
	}

	internal static class ToolbarGameScenes {
		internal static ToolbarGameScene getCurrent() {
			GameScenes scene = HighLogic.LoadedScene;
			switch (scene) {
				case GameScenes.LOADING:
					return ToolbarGameScene.LOADING;
				case GameScenes.LOADINGBUFFER:
					return ToolbarGameScene.LOADINGBUFFER;
				case GameScenes.MAINMENU:
					return ToolbarGameScene.MAINMENU;
				case GameScenes.SETTINGS:
					return ToolbarGameScene.SETTINGS;
				case GameScenes.CREDITS:
					return ToolbarGameScene.CREDITS;
				case GameScenes.SPACECENTER:
					return ToolbarGameScene.SPACECENTER;
				case GameScenes.EDITOR:
					return ToolbarGameScene.EDITOR;
				case GameScenes.FLIGHT:
					return MapView.MapIsEnabled ? ToolbarGameScene.FLIGHTMAP : ToolbarGameScene.FLIGHT;
				case GameScenes.TRACKSTATION:
					return ToolbarGameScene.TRACKSTATION;
				case GameScenes.PSYSTEM:
					return ToolbarGameScene.PSYSTEM;

				default:
					throw new ArgumentException("unknown game scene: " + scene);
			}
		}
	}
}
