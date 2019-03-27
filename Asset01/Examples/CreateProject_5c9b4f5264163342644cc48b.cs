{
   "content":    {
      "projectName": "AutoProjectName7NZ4SLSL",
      "repositoryId": 118083636,
      "repositoryName": "AutoRepositoryNameF6YVTDO0XD",
      "description": "AutoDescriptionEBVMCSJGTU",
      "typeOfContent": 3,
      "publishedPath": "testing",
      "isSourceSyncRequired": true,
      "projectId": "5a7400d942f30114c08c0c64",
      "tagGroups":       [
         "5a70246f206f3995fc17af98",
         "5a72b7c942f30114c08c09f1",
         "5a72b95a42f30114c08c09f9",
         "5a72bbf342f30114c08c09fc",
         "07fa50d8-9ed6-4915-b2c8-c2bed72b588d",
         "5a72fa9142f30114c08c0a8a",
         "5a73022b42f30114c08c0aa1"
      ],
      "gdriveId": "5a7400d942f30114c08c0c64",
      "projectCompleteStatus": 2
   },
   "userId": "S-1-5-21-1210654208-2246142303-2829877410-19101",
   "flowMap":    {
      "cmsOperation": 1,
      "eventGroups":       [
         [         {
            "eventName": 1001,
            "eventLocationInFlowMap": null,
            "status": 2,
            "childCMSOperation": 0,
            "childOperationStatus": null,
            "eventCondition": null,
            "reuseCmsOperation": 0,
            "conditionKeys": null,
            "requestMapProperty":             [
                              {
                  "source": "ProjectName",
                  "target": "ProjectName"
               },
                              {
                  "source": "RepositoryId",
                  "target": "RepositoryId"
               },
                              {
                  "source": "RepositoryName",
                  "target": "RepositoryName"
               },
                              {
                  "source": "Description",
                  "target": "Description"
               },
                              {
                  "source": "TypeOfContent",
                  "target": "TypeOfContent"
               },
                              {
                  "source": "PublishedPath",
                  "target": "PublishedPath"
               },
                              {
                  "source": "IsSourceSyncRequired",
                  "target": "IsSourceSyncRequired"
               }
            ],
            "responseMapProperty": [            {
               "source": "ProjectId",
               "target": "ProjectId"
            }]
         }],
         [         {
            "eventName": 1061,
            "eventLocationInFlowMap": null,
            "status": 2,
            "childCMSOperation": 0,
            "childOperationStatus": null,
            "eventCondition": null,
            "reuseCmsOperation": 0,
            "conditionKeys": null,
            "requestMapProperty": null,
            "responseMapProperty": [            {
               "source": "TagGroups",
               "target": "TagGroups"
            }]
         }],
         [         {
            "eventName": 4,
            "eventLocationInFlowMap": null,
            "status": 2,
            "childCMSOperation": 0,
            "childOperationStatus": null,
            "eventCondition": null,
            "reuseCmsOperation": 30,
            "conditionKeys": null,
            "requestMapProperty": null,
            "responseMapProperty": null
         }],
         [         {
            "eventName": 1040,
            "eventLocationInFlowMap": null,
            "status": 2,
            "childCMSOperation": 0,
            "childOperationStatus": null,
            "eventCondition": null,
            "reuseCmsOperation": 0,
            "conditionKeys": null,
            "requestMapProperty":             [
                              {
                  "source": "ProjectId",
                  "target": "ProjectId"
               },
                              {
                  "source": "TagGroups",
                  "target": "TagGroups"
               }
            ],
            "responseMapProperty":             [
                              {
                  "source": "ProjectId",
                  "target": "ProjectId"
               },
                              {
                  "source": "TagGroups",
                  "target": "TagGroups"
               }
            ]
         }],
                  [
                        {
               "eventName": 2001,
               "eventLocationInFlowMap": null,
               "status": 2,
               "childCMSOperation": 0,
               "childOperationStatus": null,
               "eventCondition": null,
               "reuseCmsOperation": 0,
               "conditionKeys": null,
               "requestMapProperty": [               {
                  "source": "ProjectId",
                  "target": "ProjectId"
               }],
               "responseMapProperty": [               {
                  "source": "GdriveId",
                  "target": "GdriveId"
               }]
            },
                        {
               "eventName": 3007,
               "eventLocationInFlowMap": null,
               "status": 2,
               "childCMSOperation": 0,
               "childOperationStatus": null,
               "eventCondition": "Convert.ToBoolean(IsSourceSyncRequired)==true",
               "reuseCmsOperation": 0,
               "conditionKeys": ["IsSourceSyncRequired"],
               "requestMapProperty": [               {
                  "source": "ProjectId",
                  "target": "ProjectId"
               }],
               "responseMapProperty": null
            }
         ],
         [         {
            "eventName": 1003,
            "eventLocationInFlowMap": null,
            "status": 2,
            "childCMSOperation": 0,
            "childOperationStatus": null,
            "eventCondition": null,
            "reuseCmsOperation": 0,
            "conditionKeys": null,
            "requestMapProperty": [            {
               "source": "ProjectId",
               "target": "ProjectId"
            }],
            "responseMapProperty": [            {
               "source": "ProjectCompleteStatus",
               "target": "ProjectCompleteStatus"
            }]
         }],
         [         {
            "eventName": 4,
            "eventLocationInFlowMap": null,
            "status": 2,
            "childCMSOperation": 0,
            "childOperationStatus": null,
            "eventCondition": "Convert.ToBoolean(IsSourceSyncRequired)==false",
            "reuseCmsOperation": 4,
            "conditionKeys": ["IsSourceSyncRequired"],
            "requestMapProperty": null,
            "responseMapProperty": null
         }]
      ],
      "notificationType": 2,
      "notificationTopic": "Project",
      "parentResponseId": null,
      "parentEventLocation": null,
      "isOperationCompleteWithStatusSuccess": true,
      "_id": "5a72a5e44af10f8978deb4dd",
      "status": 0,
      "modifiedDate": 0,
      "createdDate": 1517463012
   },
   "createdOn": "2018-02-02T06:10:33.474Z",
   "errorResponse": null,
   "_id": "5a7400d916850626504aa239",
   "status": 2,
   "modifiedDate": 1517551836,
   "createdDate": 1517551833
}