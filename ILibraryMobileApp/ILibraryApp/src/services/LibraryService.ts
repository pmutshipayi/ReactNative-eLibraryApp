import { LibraryViewModel } from './../models/LibraryModels';
import { AxiosResponse } from "axios";
import ApiRequest from './ApiRequest';

export default class LibraryService {

    static loadLibraries() : Promise<AxiosResponse<LibraryViewModel[]>> {
        return ApiRequest.get("api/library/");
    }

}