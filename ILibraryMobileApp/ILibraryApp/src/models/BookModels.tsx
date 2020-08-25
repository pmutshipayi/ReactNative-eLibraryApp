import {BaseEntity} from "./BaseEntity";
import {BaseImage} from "./BaseImage";
import {LibraryViewModel} from "./LibraryModels";

export interface BookViewModel extends BaseEntity {
    name: string;
    barcode: string;
    allowOnlineReservation: boolean;
    description: string;
    qtyAvailable: number;
    library: LibraryViewModel;
    isAvailable: boolean;
    images: BaseImage[];
    tags: BookTag[]
}

export interface BookTag {
    name: string
}

export interface BookSearchModel {
    pageIndex?: number;
    pageSize?: number;
    name?: string;
    tags?: string;
    libraryId?: number
}