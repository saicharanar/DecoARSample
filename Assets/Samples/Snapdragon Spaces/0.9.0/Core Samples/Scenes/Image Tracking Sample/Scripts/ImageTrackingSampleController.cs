/******************************************************************************
 * File: ImageTrackingSampleController.cs
 * Copyright (c) 2022 Qualcomm Technologies, Inc. and/or its subsidiaries. All rights reserved.
 *
 * Confidential and Proprietary - Qualcomm Technologies, Inc.
 *
 ******************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace Qualcomm.Snapdragon.Spaces.Samples
{
    public class ImageTrackingSampleController : SampleController
    {
        public ARTrackedImageManager arImageManager;
        public override void OnEnable() {
            base.OnEnable();
            arImageManager.trackedImagesChanged += OnTrackedImagesChanged;
        }

        public override void OnDisable() {
            base.OnDisable();
            arImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
        }

        private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs args) {
            foreach (var trackedImage in args.added) {
                var referenceImageName = trackedImage.referenceImage.name;
                if (referenceImageName == "SpacesTown")
                {
                    ImageTracker.Instance.currentImage = referenceImageName;
                }
                if (referenceImageName == "Earth")
                {
                    ImageTracker.Instance.currentImage = referenceImageName;
                }
            }
        }
    }
}