export * from './default.service';
import { DefaultService } from './default.service';
export * from './utilityNetworkService.service';
import { UtilityNetworkServiceService } from './utilityNetworkService.service';
export const APIS = [DefaultService, UtilityNetworkServiceService];
