#!/bin/bash
project_path="../3dtest"

output_path="/Users/chars"

/Applications/Unity/Hub/Editor/2019.4.32f1c1/Unity.app/Contents/MacOS/Unity -projectPath ${project_path} -executeMethod ReleaseTool.BuildAndroid -quit

cd ${project_path}

cp k2.pkg ${output_path}

rm -rf k2.pkg