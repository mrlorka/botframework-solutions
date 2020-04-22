/**
 * Copyright(c) Microsoft Corporation.All rights reserved.
 * Licensed under the MIT License.
 */

import { LuisRecognizerTelemetryClient, LuisRecognizer, QnAMaker } from 'botbuilder-ai';

export interface ICognitiveModelSet {
    dispatchService: LuisRecognizerTelemetryClient;
    luisServices: Map<string, LuisRecognizer>; 
    qnaServices: Map<string, QnAMaker>;
}