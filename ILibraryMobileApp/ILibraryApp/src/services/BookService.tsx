import {BookSearchModel, BookViewModel} from "../models/BookModels";
import ApiRequest from "./ApiRequest";
import {AxiosResponse} from "axios";
import {LibraryViewModel} from "../models/LibraryModels";

export class BookService {

    /**
     * Get books from the api
     * @param searchModel: search filter
     */
    static getBooks(searchModel?: BookSearchModel): Promise<AxiosResponse<BookViewModel[]>> {
        /*const params = {};
        if (searchModel) {
            if (searchModel.tag) {
                (params as any)['tags'] = searchModel.tag;
            }
            if (searchModel.libraryId)
                (params as any)["libraryId"] = searchModel.libraryId;
        }*/
        return ApiRequest.get<BookViewModel[]>('api/book', searchModel)
    }
 
    /**
     * Get similar books
     * @param bookId
     * @param pageSize
     */
    static getSimilarBooks(bookId: number): Promise<AxiosResponse<BookViewModel[]>>{
        return ApiRequest.get<BookViewModel[]>(`api/book/similar/${bookId}`);
    }

    /**
     * Get libraries having the given book
     * @param bookBarcode
     * @param exceptLibraryId
     * @param pageSize
     */
    static getLibraries(bookBarcode: string, exceptLibraryId: number, pageSize: number = 10): Promise<AxiosResponse<LibraryViewModel[]>>{
        return ApiRequest.get<LibraryViewModel[]>(`api/book/libraries/${bookBarcode}/${exceptLibraryId}/${pageSize}`);
    }
}